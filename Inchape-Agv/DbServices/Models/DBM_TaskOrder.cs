using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchape_Agv.DbServices.Models
{
    public class DBM_TaskOrder
    {
        private int _id;
        private string? _prodNo;
        private string? _statusLH;
        private string? _statusRH;
        private string? _status;
        private DateTime _startTime;
        private DateTime _endTime;
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ProdNo
        {
            get { return _prodNo; }
            set { _prodNo = value; }
        }

        public string StatusLH
        {
            get { return _statusLH; }
            set { _statusLH = value; }
        }

        public string StatusRH
        {
            get { return _statusRH; }
            set { _statusRH = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
    }
}
