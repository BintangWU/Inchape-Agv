using DbServices.Models;
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
            sqlString.Append("(idx, name, route, markId, endMarkId, typeStock, type) ");
            sqlString.Append("VALUES ");
            sqlString.Append("(@Index, @Name, @Route, @MarkId, @EndMarkId, @TypeStock, @Type)");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Index", model.Index),
                new SQLiteParameter("@Name", model.Name),
                new SQLiteParameter("@Route", model.Route),
                new SQLiteParameter("@MarkId", model.MarkId),
                new SQLiteParameter("@EndMarkId", model.EndMarkId),
                new SQLiteParameter("@TypeStock", model.TypeStock),
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
                "route= @Route, " +
                "markId= @MarkId, " +
                "endMarkId= @EndMarkId, " +
                "typeStock= @TypeStock, " +
                "type= @Type ");
            sqlString.Append("WHERE id= @Id");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", model.ID),
                new SQLiteParameter("@Index", model.Index),
                new SQLiteParameter("@Name", model.Name),
                new SQLiteParameter("@Route", model.Route),
                new SQLiteParameter("@MarkId", model.MarkId),
                new SQLiteParameter("@EndMarkId", model.EndMarkId),
                new SQLiteParameter("@TypeStock", model.TypeStock),
                new SQLiteParameter("@Type", model.Type)
            };

            int rows = DbHelper.ExecuteSql(sqlString.ToString(), parameters);
            return rows > 0;
        }

        public bool Update(string stockName, string prodNo)
        {
            //UPDATE db_stocks SET prodNo = "hioho" WHERE name = "StockA"
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
                model.ID = int.TryParse(row["id"].ToString(), out var id) ? id : 0; 
                model.Index = int.TryParse(row["idx"].ToString(), out var index) ? index : 0;
                model.Name = row["name"] == DBNull.Value ? "" : row["name"]?.ToString() ?? "";
                model.Route = int.TryParse(row["route"].ToString(), out var route) ? route : 0;
                model.MarkId = int.TryParse(row["markId"].ToString(), out var markId) ? markId : 0;     
                model.EndMarkId = int.TryParse(row["endMarkId"].ToString(), out var endMarkId) ? endMarkId : 0;
                model.TypeStock = row["typeStock"] == DBNull.Value ? "" : row["typeStock"]?.ToString() ?? "";
                model.Type = row["type"] == DBNull.Value ? "" : row["type"]?.ToString() ?? "";
                model.Status = row["status"] == DBNull.Value ? "" : row["status"]?.ToString() ?? "";
                model.ProdNo = row["prodNo"] == DBNull.Value ? "" : row["prodNo"]?.ToString() ?? "";
            }
            return model;
        }
    }
}
