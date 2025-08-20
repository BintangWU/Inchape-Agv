using DbServices.Models;
using LibCommunication;
using LibCommunication.Controller;
using LibCommunication.Messages;
using System.Data;
using System.Diagnostics;

namespace CarServices
{
    public class CarControl
    {
        private static CarControl _instance;
        private static object _instanceLock = new object();

        private static CSDispatchController CSDispatchController;
        private static volatile Dictionary<int, Car> CarDict = new Dictionary<int, Car>();

        private int _wirelessAddr;
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

        public bool InitialCommunication(string com, int baud, int wrls)
        {
            _wirelessAddr = wrls;
            CSDispatchController = new CSDispatchController(baud, com, 2);
            CSDispatchController.DispatchHubMsgRecvEvent += CSDispatchController_DispatchHubMsgRecvEvent;
            return CSDispatchController.StartWork();
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

        //Car to Storage
        public bool CarAddStock(string prodNo)
        {
            bool result = false;
            int i = 0;
            string stockName = "";
            string[] stockListname = new string[2];

            DataTable data = DbServices.DbServices.Instance.DB_Stock.GetList("WHERE (prodNo IS NULL OR prodNo='-' OR prodNo='') " +
            "AND typeStock= 'FG' " +
            "AND type IN ('LH', 'RH') " +
            "ORDER BY idx ASC, type ASC LIMIT 2").Tables["ds"];

            bool flag = data != null && data.Rows.Count == 2;
            if (flag)
            {
                foreach (DataRow dr in data.Rows)
                {
                    stockListname[i] = dr["name"].ToString();
                    i++;
                }

                if ((stockListname.Length > 0) && (stockListname[0].ToUpper() == stockListname[1].ToUpper()))
                {
                    stockName = stockListname[0];
                    DBM_TaskOrder taskOrder = new DBM_TaskOrder()
                    {
                        ProdNo = prodNo.ToString().ToUpper(),
                        Status = "In " + stockName,
                        StartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    };

                    var dialog = MessageBox.Show(
                        $"Send [{prodNo}] to Storage [{stockName.ToUpper()}]",
                        "Message",
                        MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        bool flag1 = DbServices.DbServices.Instance.DB_Stock.Update(stockName, prodNo.ToUpper());
                        if (flag1)
                        {
                            bool flag2 = DbServices.DbServices.Instance.DB_TaskOrder.Add(taskOrder) > 0;
                            if (flag2)
                            {
                                var carTask = GenTask(data);
                                foreach (var item in carTask)
                                {
                                    Debug.WriteLine($"Route: {item.Route}-{item.MarkId}");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Failed update database stock");
                        }
                    }
                }
                else
                {
                    throw new Exception("Name of stock LH and RH not match");
                }
            }
            return result;
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


        private void Thread_SendToStock(CarControl control)
        {
            Log.Instance.WriteLog("Stock", "[THREAD SendToStock] -> Starting");

            for (; ; )
            {
                try
                {
                    foreach (Car car in CarDict.Values)
                    {

                    }
                }
                catch (Exception e)
                {
                }
                Thread.Sleep(250);
            }
        }
    }
}
