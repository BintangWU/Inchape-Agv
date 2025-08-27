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
        private string? _callType;  
        private string? _destination;
        private string? _routes;
        private string? _status;
        private string? _createAt;
        

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ProdNo
        {
            get { return _prodNo; }
            set { _prodNo = value; }
        }

        public string CallType
        {
            get { return _callType; }
            set { _callType = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public string Routes
        {
            get { return _routes; }
            set { _routes = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string CreateAt
        {
            get { return _createAt; }
            set { _createAt = value; }
        }
    }
}
