using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServices
{
    public class Car
    {
        private int _carId;
        private int _routeId;
        private int _markId;
        private int _lastMakrkId;
        private int _functionCode;
        private bool _onDuty;
        
        public Car(int carId)
        {
            _carId = carId;
            _routeId = 0;
            _markId = 0;
            _functionCode = 0;
            _onDuty = false;
        }

        public Car()
        {
            _carId = 0;
            _routeId = 0;
            _markId = 0;
            _functionCode = 0;
            _onDuty = false;
        }

        public int CarId
        {
            get { return _carId; }
            set { _carId = value; }
        }

        public int RouteId
        {
            get { return _routeId; }
            set { _routeId = value; }
        }

        public int MarkId
        {
            get { return _markId; }
            set
            {
                bool flag = value != _markId && value != -1;
                if (flag)
                {
                    _lastMakrkId = _markId;
                    _markId = value;
                }
            }
        }

        public int LastMarkId
        {
            get { return _lastMakrkId; }
            set
            {
                bool flag = value != _lastMakrkId && value != -1;
                if (flag)
                    _lastMakrkId = value;
            }
        }

        public int FunctionCode
        {
            get { return _functionCode; }
            set { _functionCode = value; }
        }

        public bool OnDuty
        {
            get { return _onDuty; }
            set { _onDuty = value; }
        }
    }
}
