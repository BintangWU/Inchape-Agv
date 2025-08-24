using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbServices.Models
{
    public class DBM_TaskOrder
    {
        private int _id;
        private string? _prodNo;
        private string? _status;
        private string? _destination;
        private string? _route;
        private string? _statusTask;
        private string? _statusLH;
        private string? _statusRH;
        private string? _startTime;
        private string? _endTime;
        
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

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string StatusTask
        {
            get { return _statusTask; }
            set { _statusTask = value; }
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

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public string Route
        {
            get { return _route; }
            set { _route = value; }
        }

        public string StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public string EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
    }
}
