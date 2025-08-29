using DbServices.Models;
using System.Data;
using System.Data.SQLite;
using System.Text;
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
            sqlString.Append("(prodNo, callType, destination, routes, status, createAt) ");
            sqlString.Append("VALUES (@ProdNo, @CallType, @Destination, @Routes, @Status, @CreateAt) ");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@CallType", model.CallType),
                new SQLiteParameter("@Destination", model.Destination),
                new SQLiteParameter("@Routes", model.Routes),
                new SQLiteParameter("@Status", model.Status),
                new SQLiteParameter("@CreateAt", model.CreateAt)
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
            sqlString.Append("status= @Status, LH= @LHState, RH= @RHState ");
            sqlString.Append("WHERE id= @Id AND prodNo= @ProdNo ");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", model.Id),
                new SQLiteParameter("@ProdNo", model.ProdNo),
                new SQLiteParameter("@Status", model.Status),
                new SQLiteParameter("@LHState", model.LH),
                new SQLiteParameter("@RHState", model.RH)
            };

            int rows = DbHelper.ExecuteSql(sqlString.ToString(), parameters);
            return rows > 0;
        }

        public bool Delete(int id)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"DELETE FROM {_db} ");
            sqlString.Append("WHERE id= @Id");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", Convert.ToString(id))
            };

            int rows = DbHelper.ExecuteSql(sqlString.ToString(), parameters);
            return rows > 0;
        }

        public DataSet GetList(string query = null)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append("SELECT * ");
            sqlString.Append($"FROM {_db} ");

            bool flag = query != null;
            if (flag)
                sqlString.Append(query);
            return DbHelper.DataQuery(sqlString.ToString());
        }

        public DataSet GetOnQueue(string prodNo, string callType)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append("SELECT * ");
            sqlString.Append($"FROM {_db} ");
            sqlString.Append("WHERE status= 'Queue' AND ");
            sqlString.Append("prodNo= @ProdNo AND ");
            sqlString.Append("callType= @CallType ");
            sqlString.Append("ORDER BY id DESC ");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@ProdNo", prodNo),
                new SQLiteParameter("@CallType", callType)
            };

            return DbHelper.DataQuery(sqlString.ToString(), parameters);
        }

        public DBM_TaskOrder ToModel(DataRow row)
        {
            DBM_TaskOrder model = new DBM_TaskOrder();
            bool flag = row != null;
            if (flag)
            {
                model.Id = int.TryParse(row["id"].ToString(), out var id) ? id : 0;
                model.ProdNo = row["prodNo"] == DBNull.Value ? "" : row["prodNo"]?.ToString() ?? "";
                model.CallType = row["callType"] == DBNull.Value ? "" : row["callType"]?.ToString() ?? "";
                model.Destination = row["destination"] == DBNull.Value ? "" : row["destination"]?.ToString() ?? "";
                model.Routes = row["routes"] == DBNull.Value ? "" : row["routes"]?.ToString() ?? "";
                model.Status = row["status"] == DBNull.Value ? "" : row["status"]?.ToString() ?? "";
                model.CreateAt = row["createAt"] == DBNull.Value ? "" : row["createAt"]?.ToString() ?? "";  
                model.LH = bool.TryParse(row["LH"].ToString(), out var lhState) ? lhState : false;
                model.RH = bool.TryParse(row["RH"].ToString(), out var rhState) ? rhState : false;
            }
            return model;
        }
    }
}
