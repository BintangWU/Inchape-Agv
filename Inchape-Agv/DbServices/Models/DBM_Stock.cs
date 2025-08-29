namespace DbServices.Models
{
    [Serializable]
    public class DBM_Stock
    {
        private int _id;
        private int _index;
        private string _name;
        private int _routeIn;
        private int _routeOut;
        private int _landMark;
        private int _endlandMark;
        private string _door;
        private string _type;
        private string _prodNo;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RouteIn
        {
            get { return _routeIn; }
            set { _routeIn = value; }
        }

        public int RouteOut
        {
            get { return _routeOut; }
            set { _routeOut = value; }
        }

        public int LandMark
        {
            get { return _landMark; }
            set { _landMark = value; }
        }

        public int EndLandMark
        {
            get { return _endlandMark; }
            set { _endlandMark = value; }
        }

        public string Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string ProdNo
        {
            get { return _prodNo; }
            set { _prodNo = value; }
        }
    }
}
