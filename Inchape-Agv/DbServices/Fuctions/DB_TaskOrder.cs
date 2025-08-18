using DbServices.Models;
using Inchape_Agv.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
            //SELECT* from db_stocks WHERE prodNo IS NULL AND typeStock = "FG" AND type IN('LH', 'RH') ORDER BY idx ASC, type ASC LIMIT 2;

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@Status", model.Status),
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
                "endTime= @EndTime ");
            sqlString.Append("WHERE prodNo= @ProdNo");

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@status", model.Status)
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
