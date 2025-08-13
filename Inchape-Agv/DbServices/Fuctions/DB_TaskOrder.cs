using Inchape_Agv.DbServices.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchape_Agv.DbServices.Fuctions
{
    public class DB_TaskOrder
    {
        private string _db = "db_taskOrder";

        public int Add(DBM_TaskOrder model)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"INSERT INTO {_db} ");
            sqlString.Append("(prodNo, startTime) ");
            sqlString.Append("VALUES (@ProdNo, @StartTime) ");

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@StartTime", model.StartTime)
            ];

            object obj = DbHelper.GetSingle(sqlString.ToString(), parameters);
            bool flag = obj == null;
            int results;

            if (flag)
                results = 0;
            else
                results = Convert.ToInt32(obj);
            return results; 
        }

        public bool Update(DBM_TaskOrder model)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"UPDATE {_db} SET ");
            sqlString.Append("statusLH= @StatusLH, " +
                "statusRH= @StatusRH, " +
                "status= @Status, " +
                "endTime= @EndTime ");
            sqlString.Append("WHERE prodNo= @ProdNo");

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@status", model.Status),
                new SQLiteParameter("@statusLH", model.StatusLH),
                new SQLiteParameter("@statusRH", model.StatusRH)
            ];

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
