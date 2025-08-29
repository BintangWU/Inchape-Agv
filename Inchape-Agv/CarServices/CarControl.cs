using DbServices.Models;
using LibCommunication;
using LibCommunication.Controller;
using LibCommunication.Messages;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace CarServices
{
    public class CarControl
    {
        private static CarControl _instance;
        private static object _instanceLock = new object();

        private static CSDispatchController CSDispatchController;
        private static volatile Dictionary<int, Car> CarDict = new Dictionary<int, Car>();
        private static string _logName = "CarControl"; 

        private int _wirelessAddr;
        private int[] _markHome;
        public static CarControl Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new CarControl();
                    return _instance;
                }
            }
        }

        public bool InitialCommunication(string com, int baud)
        {
            CSDispatchController = new CSDispatchController(baud, com, 2);
            CSDispatchController.DispatchHubMsgRecvEvent += CSDispatchController_DispatchHubMsgRecvEvent;
            Trace.WriteLine("OK");
            return CSDispatchController.StartWork();
        }

        public void InitialCarSystem(int wrlsAddr, string markHome)
        {
            _wirelessAddr = wrlsAddr;
            _markHome = markHome.ToString()
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Thread Thread_Dispatching = new Thread(() => Thread_DispatchingCar(this));
            Thread_Dispatching.IsBackground = true;
            Thread_Dispatching.Start();
        }

        private void CSDispatchController_DispatchHubMsgRecvEvent(LibCommunication.ConnectorBase connector, LibCommunication.IBaseMessage msg)
        {
            try
            {
                if (msg == null)
                    return;

                //CSDispatchMessage cs = msg as CSDispatchMessage;
                //Debug.WriteLine($"{cs.LogString}");
                //Debug.WriteLine($"{cs.FunctionCode} {cs.AGVID} {cs.StartMarkID} {cs.RouteID} {cs.WirelessAddress}");

                if (msg.MessageType == MessageTypes.CSDispatch && msg.AGVID != 0)
                {
                    lock (CarDict)
                    {
                        CSDispatchMessage mm = msg as CSDispatchMessage;
                        //Debug.WriteLine($"{mm.FunctionCode} {mm.AGVID} {mm.StartMarkID} {mm.RouteID} {mm.WirelessAddress}");
                        if (mm.WirelessAddress == this._wirelessAddr)
                        {
                            if (CarDict.ContainsKey(mm.AGVID))
                            {
                                Car car = CarDict[mm.AGVID];
                                car.MarkId = mm.StartMarkID;
                                car.RouteId = mm.RouteID;
                                car.FunctionCode = mm.FunctionCode;
                                Debug.WriteLine($"The car on the list [{car.CarId}]");
                            }
                            else
                            {
                                Car car = new Car(mm.AGVID);
                                car.OnDuty = false;
                                car.MarkId = mm.StartMarkID;
                                car.RouteId = mm.RouteID;
                                car.FunctionCode = mm.FunctionCode;
                                CarDict.Add(mm.AGVID, car);
                                Debug.WriteLine($"No car on the list [{car.CarId}]");
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void ReleaseCar(int markId, int route = 0)
        {
            CSDispatchMessage msg = new CSDispatchMessage();
            msg.FunctionCode = 55;
            msg.StartMarkID = markId;
            msg.RouteID = route;

            for (int i = 0; i < 8; i++)
                CSDispatchController.SendMessage(msg);
        }


        //public List<(int Route, int MarkId)> GenTask(DataTable data)
        //{
        //    if (data?.Rows == null || data.Rows.Count == 0)
        //        return new List<(int Route, int MarkId)>();

        //    return data.Rows.Cast<DataRow>().Select(row =>
        //    {
        //        try
        //        {
        //            var temp = DbServices.DbServices.Instance.DB_Stock.ToModel(row);
        //            //return (temp.Route, temp.MarkId);
        //        }
        //        catch
        //        {
        //            return default;
        //        }
        //    }).Where(x => x != default).ToList();
        //}

        private static void Thread_EmptyStock(CarControl control)
        {
            Debug.WriteLine("[THREAD EMPTY-STOCK] -> Starting");
            Log.Instance.WriteLog(_logName, "[THREAD EMPTY-STOCK] -> Starting");

            for (;;)
            {
                try
                {
                    foreach (Car car in CarDict.Values)
                    {

                    }
                }
                catch (Exception ex) { }
                Thread.Sleep(150);
            }
        }

        private static void Thread_DispatchingCar(CarControl control)
        {
            Debug.WriteLine("[THREAD DISPACHING] -> Starting");
            Log.Instance.WriteLog(_logName, "[THREAD DISPACHING] -> Starting");

            bool hasCar = false;
            int[] markHome = control._markHome;
            DataTable taskOrder = null;

            for (;;)
            {
                try
                {
                    foreach (Car car in CarDict.Values)
                    {
                        //Check stop car at Home position
                        bool isHome = markHome.Contains(car.MarkId);
                        if (isHome && !car.OnDuty && car.FunctionCode == 55)
                        {
                            //Check TaskOrder data with status 'Queue' and the Car available
                            taskOrder = DbServices.DbServices
                                .Instance.DB_TaskOrder
                                .GetList("WHERE (status = 'Queue' OR status = 'Process') " +
                                    "AND (LH IS NULL OR LH = '' OR LH = False OR RH IS NULL OR RH = '' OR RH = False) " +
                                    "ORDER BY id ASC LIMIT 1").Tables["ds"];
                            hasCar = true;
                        }
                        else
                            continue;
                    }

                    if (hasCar && taskOrder != null) 
                    {
                        foreach (Car car in CarDict.Values)
                        {
                            bool isHome = markHome.Contains(car.MarkId);
                            if (isHome && !car.OnDuty && car.FunctionCode == 55)
                            {
                                DBM_TaskOrder taskModel = DbServices.DbServices
                                    .Instance.DB_TaskOrder
                                    .ToModel(taskOrder.Rows[0]);
                                
                                int[] routes = taskModel.Routes.ToString()
                                    .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse).ToArray();
                                int indexLandMark = Array.IndexOf(markHome, car.MarkId);

                                taskModel.Status = "Process";
                                switch (indexLandMark)
                                {
                                    case 0: taskModel.LH = true; break;
                                    case 1: taskModel.RH = true; break;
                                    default: break;
                                }

                                DbServices.DbServices.Instance.DB_TaskOrder.Update(taskModel);
                                
                                Debug.WriteLine($"Release: Car[{car.MarkId}] to Route:{routes[indexLandMark]}");
                                //control.ReleaseCar(car.MarkId, routes[indexLandMark]);
                                car.OnDuty = true;
                            }
                        }
                    }                          
                }
                catch (Exception ex)
                {
                    var st = new StackTrace();
                    Debug.WriteLine($"[{ex.StackTrace}][{st.GetFrame(0).GetFileLineNumber()}]=> {ex.Message}\"");
                    //Log.Instance.WriteLog(_logName, $"[THREAD DISPACHING] Loop Exception [{ex.StackTrace}][{st.GetFrame(0).GetFileLineNumber()}]=> {ex.Message}");
                }
                Thread.Sleep(250);
            }
        }

        private void Thread_CheckPoint(CarControl control)
        {
            Log.Instance.WriteLog(_logName, "[THREAD DISPACHING] -> Starting");

            int lastStock = 0;

            for (; ; )
            {
                try
                {
                    foreach (Car car in CarDict.Values)
                    {
                        if (car.MarkId != car.LastMarkId)
                        {
                            lastStock += 1;
                            StringBuilder sqlString = new StringBuilder();
                            sqlString.Append($"WHERE markId='{car.MarkId}' ");
                            sqlString.Append("AND typeStock='Trolley' ");

                            DbServices.DbServices.Instance.DB_Stock.GetList(sqlString.ToString());
                            
                            car.LastMarkId = car.MarkId;
                        }
                    }
                }
                catch (Exception ex)
                {
                    var st = new StackTrace();
                    Log.Instance.WriteLog(_logName, $"[THREAD CHECKPOINT] Loop Exception [{ex.StackTrace}][{st.GetFrame(0).GetFileLineNumber()}]=> {ex.Message}");
                }
                Thread.Sleep(250);
            }
        }
    }
}
