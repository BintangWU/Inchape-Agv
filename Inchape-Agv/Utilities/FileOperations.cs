using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Inchape_Agv.Utilities
{
    public class FileOperations
    {
        public static bool ExportCSV(Dictionary<string, string> dataMap, DataTable data, string filePath)
        {
            try
            {
                var headers = dataMap.Keys.ToArray();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(string.Join(",", headers.Select(c => dataMap[c])));
                    foreach (DataRow dr in data.Rows)
                    {
                        var values = headers.Select(col => dr[col]?.ToString() ?? "").ToArray();
                        writer.WriteLine(string.Join(",", values));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable ImportCSV(Dictionary<string, string> dataMap, string filePath)
        {
            DataTable data = new DataTable();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var headers = reader.ReadLine().Split(',');
                    var reverseMap = dataMap.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                    var headersMap = headers.Select(h => reverseMap.ContainsKey(h) ? reverseMap[h] : h).ToList();

                    foreach (var header in headersMap)
                        data.Columns.Add(header);

                    while (!reader.EndOfStream)
                    {
                        var content = reader.ReadLine().Split(',');
                        DataRow row = data.NewRow();
                        for (int i = 0; i < headersMap.Count(); i++)
                            row[headersMap[i]] = content[i];
                        data.Rows.Add(row);
                    }
                    return data;
                }
            }
            catch
            {
                return data = null;
            }



        }
        public static bool ImportCSV()
        {
            return false;
        }
    }
}
