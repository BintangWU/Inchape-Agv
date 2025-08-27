using DbServices.Models;
using Microsoft.Extensions.Primitives;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DbServices.Fuctions
{
    public class DB_Stock
    {
        private string _db = "db_stocks";
        public int Add(DBM_Stock model)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"INSERT INTO {_db} ");
            sqlString.Append("(idx, name, routeIn, routeOut, landMark, endLandMark, door, type) ");
            sqlString.Append("VALUES ");
            sqlString.Append("(@Index, @Name, @RouteIn, @RouteOut, @LandMark, @EndLandMark, @Door, @Type)");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Index", model.Index),
                new SQLiteParameter("@Name", model.Name),
                new SQLiteParameter("@RouteIn", model.RouteIn),
                new SQLiteParameter("@RouteOut", model.RouteOut),
                new SQLiteParameter("@LandMark", model.LandMark),
                new SQLiteParameter("@EndLandMark", model.EndLandMark),
                new SQLiteParameter("@Door", model.Door),
                new SQLiteParameter("@Type", model.Type)
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

        public bool Update(DBM_Stock model)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"UPDATE {_db} SET ");
            sqlString.Append("idx= @Index, " +
                "name= @Name, " +
                "routeIn= @RouteIn, " +
                "routeOut= @RouteOut, " +
                "landMark= @LandMark, " +
                "endLandMark= @EndLandMark, " +
                "door= @Door, " +
                "type= @Type ");
            sqlString.Append("WHERE id= @Id");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", model.Id),  
                new SQLiteParameter("@Index", model.Index),
                new SQLiteParameter("@Name", model.Name),
                new SQLiteParameter("@RouteIn", model.RouteIn),
                new SQLiteParameter("@RouteOut", model.RouteOut),
                new SQLiteParameter("@LandMark", model.LandMark),
                new SQLiteParameter("@EndLandMark", model.EndLandMark),
                new SQLiteParameter("@Door", model.Door),
                new SQLiteParameter("@Type", model.Type)
            };

            int rows = DbHelper.ExecuteSql(sqlString.ToString(), parameters);
            return rows > 0;
        }

        public bool Update(string stockName, string prodNo)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"UPDATE {_db} SET ");
            sqlString.Append("prodNo= @ProdNo ");
            sqlString.Append("WHERE name= @Name " +
                "AND (prodNo IS NULL OR prodNo='-' OR prodNo='')");

            SQLiteParameter[] parameters = 
            [
            
                new SQLiteParameter("@Name", stockName),
                new SQLiteParameter("@ProdNo", prodNo)
            ];

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
                sqlString.Append($"{query} ");
            return DbHelper.DataQuery(sqlString.ToString());
        }

        public DBM_Stock ToModel(DataRow row)
        {
            DBM_Stock model = new DBM_Stock();
            bool flag = row != null;
            if (flag)
            {
                model.Id = int.TryParse(row["id"].ToString(), out var id) ? id : 0; 
                model.Index = int.TryParse(row["idx"].ToString(), out var index) ? index : 0;
                model.Name = row["name"] == DBNull.Value ? "" : row["name"]?.ToString() ?? "";
                model.RouteIn = int.TryParse(row["routeIn"].ToString(), out var routeIn) ? routeIn : 0;
                model.RouteOut = int.TryParse(row["routeIn"].ToString(), out var routeOut) ? routeOut : 0;
                model.LandMark = int.TryParse(row["landMark"].ToString(), out var landMark) ? landMark : 0;     
                model.EndLandMark = int.TryParse(row["endLandMark"].ToString(), out var endLandMark) ? endLandMark : 0;
                model.Door = row["door"] == DBNull.Value ? "" : row["door"]?.ToString() ?? "";
                model.Type = row["type"] == DBNull.Value ? "" : row["type"]?.ToString() ?? "";
                model.ProdNo = row["prodNo"] == DBNull.Value ? "" : row["prodNo"]?.ToString() ?? "";
            }
            return model;
        }
    }
}
