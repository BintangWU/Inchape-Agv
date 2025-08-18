using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbServices.Models
{
    [Serializable]
    public class DBM_Stock
    {
        private int _id;
        private string? _name;
        private int _route;
        private int _markId;
        private int _endMarkId;
        private string? _typeStock;
        private string? _type;
        private string? _status;
        private string? _prodNo;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Route
        {
            get { return _route; }
            set { _route = value; }
        }

        public int MarkId
        {
            get { return _markId; }
            set { _markId = value; }
        }

        public int EndMarkId
        {
            get { return _endMarkId; }
            set { _endMarkId = value; }
        }

        public string TypeStock
        {
            get { return _typeStock; }
            set { _typeStock = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string ProdNo
        {
            get { return _prodNo; }
            set { _prodNo = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
