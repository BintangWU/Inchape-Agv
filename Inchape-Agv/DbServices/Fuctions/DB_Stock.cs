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

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@Index", model.Index),
                new SQLiteParameter("@Name", model.Name),
                new SQLiteParameter("@Route", model.Route),
                new SQLiteParameter("@MarkId", model.MarkId),
                new SQLiteParameter("@EndMarkId", model.EndMarkId),
                new SQLiteParameter("@TypeStock", model.TypeStock),
                new SQLiteParameter("@Type", model.Type)
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
                "type= @Type " );
            sqlString.Append("WHERE id= @Id");

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@Id", model.ID),
                new SQLiteParameter("@Index", model.Index),
                new SQLiteParameter("@Name", model.Name),
                new SQLiteParameter("@Route", model.Route),
                new SQLiteParameter("@MarkId", model.MarkId),
                new SQLiteParameter("@EndMarkId", model.EndMarkId),
                new SQLiteParameter("@TypeStock", model.TypeStock),
                new SQLiteParameter("@Type", model.Type)
            ];

            int rows = DbHelper.ExecuteSql(sqlString.ToString(), parameters);    
            return rows > 0;    
        }

        public bool Update(string stockName, string prodNo)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.Append($"UPDATE {_db} SET ");
            sqlString.Append("prodNo= @ProdNo ");
            sqlString.Append("WHERE name= @Name");

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

            SQLiteParameter[] parameters = [
                new SQLiteParameter("@Id", Convert.ToString(id))
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
