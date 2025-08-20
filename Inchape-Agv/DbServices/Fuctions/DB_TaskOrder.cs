using DbServices.Models;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DbServices.Fuctions
{
    public class DB_TaskOrder
    {
        private string _db = "db_taskOrder";

        public int Add(DBM_TaskOrder model)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"INSERT INTO {_db} ");
            sqlString.Append("(prodNo, status, startTime) ");
            sqlString.Append("VALUES (@ProdNo, @Status, @StartTime) ");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@Status", model.Status),
                new SQLiteParameter("@StartTime", model.StartTime)
            };

            object obj = DbHelper.GetSingle(sqlString.ToString(), parameters);
            bool flag = obj == null;
            int results;

            if (flag)
                results = 0;
            else
                results = Convert.ToInt32(obj);
            return results; 
        }

        public bool Update(DBM_TaskOrder model) //Update TaskOrder by ProdNo
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"UPDATE {_db} SET ");
            sqlString.Append("status= @Status, endTime= @EndTime ");
            sqlString.Append("WHERE prodNo= @ProdNo ");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@tatus", model.Status),
                new SQLiteParameter("EndTime", model.EndTime)
            };

            int rows = DbHelper.ExecuteSql(sqlString.ToString(), parameters);
            return rows > 0;
        }

        public DataSet GetList()
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append("SELECT * ");
            sqlString.Append($"FROM {_db} ");
            return DbHelper.DataQuery(sqlString.ToString());
        }
    }
}
