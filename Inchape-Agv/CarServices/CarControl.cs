using DbServices.Models;
using LibCommunication;
using LibCommunication.Controller;
using LibCommunication.Messages;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CarServices
{
    public class CarControl
    {
        private static CarControl _instance;
        private static object _instanceLock = new object();

        private static CSDispatchController CSDispatchController;
        private static volatile Dictionary<int, Car> CarDict = new Dictionary<int, Car>();

        private string _logName = "CarControl"; 
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
            return CSDispatchController.StartWork();
        }

        public void InitialCarSystem(int wrlsAddr, string markHome)
        {
            _wirelessAddr = wrlsAddr;
            _markHome = markHome.ToString().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        public void InitialThread()
        {
        }

        private void CSDispatchController_DispatchHubMsgRecvEvent(LibCommunication.ConnectorBase connector, LibCommunication.IBaseMessage msg)
        {
            try
            {
                if (msg == null)
                    return;

                //CSDispatchMessage mm = msg as CSDispatchMessage;
                //Debug.WriteLine($"{mm.LogString}");
                //Debug.WriteLine($"{mm.FunctionCode} {mm.RouteID} {mm.WirelessAddress}");

                if (msg.MessageType == MessageTypes.CSDispatch && msg.AGVID != 0)
                {
                    lock (CarDict)
                    {
                        CSDispatchMessage mm = msg as CSDispatchMessage;
                        if (mm.WirelessAddress == _wirelessAddr)
                        {
                            if (CarDict.ContainsKey(mm.AGVID))
                            {
                                Car car = CarDict[mm.AGVID];
                                car.MarkId = mm.StartMarkID;
                                car.RouteId = mm.RouteID;
                                car.FunctionCode = mm.FunctionCode;
                            }
                            else
                            {
                                Car car = new Car(mm.AGVID);
                                car.OnDuty = false;
                                car.MarkId = mm.StartMarkID;
                                car.RouteId = mm.RouteID;
                                car.FunctionCode = mm.FunctionCode;
                                CarDict.Add(mm.AGVID, car);
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


        public List<(int Route, int MarkId)> GenTask(DataTable data)
        {
            if (data?.Rows == null || data.Rows.Count == 0)
                return new List<(int Route, int MarkId)>();

            return data.Rows.Cast<DataRow>().Select(row =>
            {
                try
                {
                    var temp = DbServices.DbServices.Instance.DB_Stock.ToModel(row);
                    return (temp.Route, temp.MarkId);
                }
                catch
                {
                    return default;
                }
            }).Where(x => x != default).ToList();
        }


        private void Thread_DispatchingCar(CarControl control)
        {
            Log.Instance.WriteLog(_logName, "[THREAD DISPACHING] -> Starting");

            bool hasCar = false;
            int routeIdx = 0 ;
            int[] markHome = control._markHome;

            for (;;)
            {
                try
                {
                    foreach (Car car in CarDict.Values)
                    {
                        //Check stop car at Home position
                        if (car.FunctionCode == 53 && markHome.Contains(car.MarkId))
                        {
                            
                            if (car.OnDuty)
                            {
                                routeIdx = Array.IndexOf(markHome, car.MarkId);
                                car.OnDuty = false;
                            }

                            DataTable taskOrderData = DbServices.DbServices
                                .Instance.DB_TaskOrder.GetList().Tables["ds"]
                                .Select("endTime IS NULL", "id DESC")
                                .CopyToDataTable();

                            bool flag = taskOrderData != null && taskOrderData.Rows.Count > 0;
                            if (flag)
                            {
                                int[] routes = taskOrderData.Rows[0]["route"].ToString()
                                    .Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse).ToArray();

                                this.ReleaseCar(car.MarkId, routes[routeIdx]);
                                car.OnDuty = true;
                            }

                        }
                        else
                            continue;
                    }
                            
                }
                catch (Exception ex)
                {
                    var st = new StackTrace();
                    Log.Instance.WriteLog(_logName, $"[THREAD DISPACHING] Loop Exception [{ex.StackTrace}][{st.GetFrame(0).GetFileLineNumber()}]=> {ex.Message}");
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
