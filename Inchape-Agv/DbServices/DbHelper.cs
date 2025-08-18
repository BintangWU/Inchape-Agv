using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace DbServices
{
    public class DbHelper
    {
        private static string dbConnectionString = string.Format(@"Data Source= {0}\Database.db", System.Windows.Forms.Application.StartupPath.ToString());

        private static void PrepareCommand(SQLiteConnection conn, SQLiteTransaction trans, SQLiteCommand cmd, string cmdText, SQLiteParameter[] parameters)
        {
            bool flag = conn.State != ConnectionState.Open;
            if (flag)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            bool flag2 = trans != null;
            if (flag2)
                cmd.Transaction = trans;

            cmd.CommandType = CommandType.Text;
            bool flag3 = parameters != null;
            if (flag3)
            {
                foreach (SQLiteParameter parameter in parameters)
                {
                    bool flag4 = (parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && parameter.Value == null;
                    if (flag4)
                        parameter.Value = DBNull.Value;

                    cmd.Parameters.Add(parameter);
                }
            }
        }

        public static object GetSingle(string sqlQuery, SQLiteParameter[] parameters)
        {
            object result;
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    try
                    {
                        DbHelper.PrepareCommand(connection, null, command, sqlQuery, parameters);
                        object obj = command.ExecuteNonQuery();
                        command.Parameters.Clear();

                        bool flag = object.Equals(obj, null) || object.Equals(obj, DBNull.Value);
                        if (flag)
                            result = null;
                        else
                            result = obj;
                    }
                    catch (SQLiteException ex)
                    {
                        result = null;
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
            return result;
        }

        public static int ExecuteSql(string sqlQuery, SQLiteParameter[] parameters)
        {
            int result;
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    try
                    {
                        DbHelper.PrepareCommand(connection, null, command, sqlQuery, parameters);
                        int rows = command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        result = rows;
                    }
                    catch (SQLiteException ex)
                    {
                        result = -1;
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
            return result;
        }

        public static DataSet DataQuery(string sqlQuery)
        {
            DataSet results;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
                {
                    DataSet ds = new DataSet();
                    bool flag = connection.State != ConnectionState.Open;
                    if (flag)
                        connection.Open();

                    SQLiteDataAdapter command = new SQLiteDataAdapter(sqlQuery, connection);
                    command.Fill(ds, "ds");
                    results = ds;
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            return results;
        }

        public static DataSet DataQuery(string sqlQuery, SQLiteParameter[] parameters)
        {
            DataSet results;
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand();
                DbHelper.PrepareCommand(connection, null, command, sqlQuery, parameters);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        adapter.Fill(ds, "ds");
                        command.Parameters.Clear();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    results = ds;
                }
                return results;
            }
        }

        public static bool Exists(string sqlQuery, SQLiteParameter[] parameters)
        {
            object obj = DbHelper.GetSingle(sqlQuery, parameters);
            bool flag = object.Equals(obj, null) || object.Equals(obj, DBNull.Value);
            int cmdResult;
            if (flag)
                cmdResult = 0;
            else
                cmdResult = int.Parse(obj.ToString());

            bool flag2 = cmdResult == 0 | cmdResult == -1;
            return !flag2;
        }
    }
}
