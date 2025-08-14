using Inchape_Agv.DbServices.Fuctions;
using Inchape_Agv.DbServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCommunication.Controller;
using LibCommunication.Messages;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;

namespace CarServices
{
    public class CarControl
    {
        private static CarControl _instance;
        private static object _instanceLock = new object();

        private static CSDispatchController CSDispatchController;
        private static volatile Dictionary<int, Car> CarDict = new Dictionary<int, Car>();
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

        public void InitialCommunication()
        {
            CSDispatchController = new CSDispatchController(9600, "COM3", 2);
            CSDispatchController.DispatchHubMsgRecvEvent += CSDispatchController_DispatchHubMsgRecvEvent;
            bool flag = CSDispatchController.StartWork();
            Debug.WriteLine($"Serial: {flag}");
        }

        private void CSDispatchController_DispatchHubMsgRecvEvent(LibCommunication.ConnectorBase connector, LibCommunication.IBaseMessage msg)
        {
            try
            {
                if (msg == null)
                    return;

                CSDispatchMessage mm = msg as CSDispatchMessage;
                Debug.WriteLine($"{mm.LogString}");
                Debug.WriteLine($"{mm.FunctionCode} {mm.RouteID} {mm.WirelessAddress}");
            }
            catch { }
        }
    }
}
