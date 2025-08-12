using Inchape_Agv.DbServices.Fuctions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchape_Agv.DbServices
{
    public class DbServices
    {
        private static DbServices _instance;
        private static object _instanceLock = new object();

        private DB_Stock? _dbStock;

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
                    _dbStock = new DB_Stock(); // or inject it somehow
                return _dbStock;
            }
        }
    }
}
