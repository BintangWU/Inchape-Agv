using DbServices.Models;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DbServices.Fuctions
{
    public class DB_InOutbound
    {
        public DataTable InboudStock(string prodNo)
        {
            DataTable result = null;
            string stockName = "";
            string[] stockListname = new string[2];
            int[] route = new int[2];

            DataTable data = DbServices.Instance.DB_Stock.GetList("WHERE (prodNo IS NULL OR prodNo='-' OR prodNo='') " +
            "AND typeStock= 'FG' " +
            "AND type IN ('LH', 'RH') " +
            "ORDER BY idx ASC, type ASC LIMIT 2").Tables["ds"];

            if (data != null && data.Rows.Count == 2)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    stockListname[i] = data.Rows[i]["name"].ToString();
                    route[i] = int.TryParse(data.Rows[i]["route"].ToString(), out var routeId) ? routeId : 0;
                }

                if (stockListname[0].ToUpper() == stockListname[1].ToUpper())
                {
                    stockName = stockListname[0];
                    DBM_TaskOrder taskOrder = new DBM_TaskOrder()
                    {
                        ProdNo = prodNo.ToString(),
                        Status = "Inbound",
                        Destination = stockName.ToString(),
                        Route = string.Join(",", route),
                        StartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    };

                    bool flag = DbServices.Instance.DB_Stock.Update(stockName, prodNo);
                    if (flag)
                    {
                        bool flag1 = DbServices.Instance.DB_TaskOrder.Add(taskOrder) > 0;
                        if (flag1)
                        {
                            result = data;
                        }
                        else
                        {
                            result = null;
                            throw new Exception($"Failed add TaskOrder [{stockName}][{prodNo}]");
                        }
                    }
                    else
                    {
                        result = null;
                        throw new Exception($"Failed update Stock [{stockName}][{prodNo}]");
                    }
                }
                else
                {
                    result = null;
                    throw new Exception("Name of stock LH and RH not match");
                }
            }
            else
            {
                result = null;
                throw new Exception("Data Stock is Null or Invalid");
            }
            return result;
        }

        public DataTable Outbound(string prodNo)
        {
            DataTable result = null;
            string stockName = "";
            string[] stockListname = new string[2];

            StringBuilder sqlString = new StringBuilder();
            sqlString.Append("SELECT * ");
            sqlString.Append($"FROM  db_stocks ");
            sqlString.Append("WHERE prodNo= @ProdNo ");
            sqlString.Append("AND typeStock= 'FG' AND type IN ('LH', 'RH') ");
            sqlString.Append("ORDER BY idx ASC, type ASC LIMIT 2");

            SQLiteParameter[] parameters =
            [
                new SQLiteParameter("@ProdNo", prodNo)
            ];

            DataTable data = DbHelper.DataQuery(sqlString.ToString(), parameters).Tables["ds"];
            

            
            
            return result;
        }
    }
}
