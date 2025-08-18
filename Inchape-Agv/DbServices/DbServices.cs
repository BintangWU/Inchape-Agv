using DbServices.Fuctions;

namespace DbServices
{
    public class DbServices
    {
        private static DbServices _instance;
        private static object _instanceLock = new object();

        private DB_Stock? _dbStock;
        private DB_TaskOrder? _dbTaskOrder;

        public static DbServices Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new DbServices();
                    return _instance;
                }
            }
        }

        public DB_Stock DB_Stock
        {
            get
            {
                if (_dbStock == null)
                    _dbStock = new DB_Stock();
                return _dbStock;
            }
        }

        public DB_TaskOrder DB_TaskOrder
        {
            get
            {
                if (_dbTaskOrder == null)
                    _dbTaskOrder = new DB_TaskOrder();
                return _dbTaskOrder;
            }
        }
    }
}
