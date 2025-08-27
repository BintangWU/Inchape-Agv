using System.Data;

namespace Inchape_Agv.Utilities
{
    public class FileOperations
    {
        public static bool ExportCSV(Dictionary<string, string> dataMap, DataTable data, string filePath)
        {
            bool result = false;    
            try
            {
                var headers = dataMap.Keys.ToArray();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(string.Join(",", headers.Select(c => dataMap[c])).ToString().ToUpper());
                    foreach (DataRow dr in data.Rows)
                    {
                        var values = headers.Select(col => dr[col]?.ToString() ?? "").ToArray();
                        writer.WriteLine(string.Join(",", values));
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw new Exception($"Export CSV failed: {ex.Message}");
            }
            return result;
        }

        public static DataTable ImportCSV(Dictionary<string, string> dataMap, string filePath)
        {
            DataTable result = null;
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    DataTable data = new DataTable();
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
                    result = data;
                }
            }
            catch (Exception ex)
            {
                result = null;
                throw new Exception($"Import CSV failed: {ex.Message}");
            }
            return result;
        }
    }
}
