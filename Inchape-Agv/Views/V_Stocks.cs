using DbServices.Models;
using FontAwesome.Sharp;
using Inchape_Agv.Utilities;
using System.Data;
using System.Diagnostics;

namespace Inchape_Agv.Views
{
    public partial class V_Stocks : UserControl, ILoadData
    {
        private static DataTable dtStocks = new DataTable();
        private int selectedId;
        private Dictionary<string, string> headerMap = new Dictionary<string, string>
        {
            { "idx", "IDX" },
            { "name", "NAME" },
            { "routeIn", "ROUTE_IN" },
            { "routeOut", "ROUTE_OUT" },
            { "landMark", "MARK" },
            { "endLandMark", "END_MARK" },
            { "door", "DOOR" },
            { "type", "TYPE" },
            { "prodNo", "CODE" }
        };

        public V_Stocks()
        {
            InitializeComponent();

            btn_add.Tag = "add";
            btn_update.Tag = "update";
            btn_import.Tag = "import";
            btn_export.Tag = "export";

            btn_add.Click += Button_Click;
            btn_update.Click += Button_Click;
            btn_import.Click += Button_Click;
            btn_export.Click += Button_Click;

            tb_index.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_routeIn.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_routeOut.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_landMark.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_endLandMark.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
        }

        private void ClearForm()
        {
            tb_index.Clear();
            tb_name.Clear();
            tb_routeIn.Clear();
            tb_routeOut.Clear();
            tb_landMark.Clear();
            tb_endLandMark.Clear();

            cbo_type.Text = "";
            cbo_type.SelectedIndex = -1;
            cbo_door.Text = "";
            cbo_door.SelectedIndex = -1;
        }

        public void LoadData()
        {
            DataTable dt = DbServices.DbServices.Instance.DB_Stock.GetList().Tables["ds"];
            dtStocks.Rows.Clear();

            foreach(DataRow row in dt.Rows)
            {
                DataRow dr = dtStocks.NewRow();
                dr["id"] = row["id"];
                dr["idx"] = row["idx"];
                dr["name"] = row["name"];
                dr["routeIn"] = row["routeIn"];
                dr["routeOut"] = row["routeOut"];
                dr["mark"] = row["landMark"];
                dr["endMark"] = row["endLandMark"];
                dr["door"] = row["door"];
                dr["type"] = row["type"];
                dr["code"] = row["prodNo"];
                dtStocks.Rows.Add(dr);
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            try
            {
                if (sender is IconButton btn)
                {
                    string action = btn.Tag?.ToString() ?? "";
                    switch (action)
                    {
                        case "add":
                            bool flag1 = cbo_type.SelectedItem != null;
                            bool flag2 = cbo_door.SelectedItem != null;

                            if (flag1 && flag2)
                                DataUpdate();
                            else
                            {
                                string message = (!flag1 ? "Please select a TypeStock.\n" : "") + (!flag2 ? "Please select a Type." : "");
                                if (!string.IsNullOrEmpty(message))
                                    MessageBox.Show(message);
                            }
                            break;

                        case "update":
                            int id = selectedId;
                            Debug.WriteLine($"Update ID: {id}");
                            DataUpdate(id);
                            break;

                        case "import":
                            ImportDialog();
                            break;

                        case "export":
                            ExportDialog();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private DataTable ImportFromCSV(Dictionary<string, string> headerMap, string filePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                var headers = reader.ReadLine().Split(',');
                var headersMap = headers.Select(h => headerMap.ContainsKey(h) ? headerMap[h] : h).ToList();

                foreach (var col in headersMap)
                    dt.Columns.Add(col);

                while(!reader.EndOfStream)
                {
                    var content = reader.ReadLine().Split(',');
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < headersMap.Count; i++)
                        row[headersMap[i]] = content[i];
                    dt.Rows.Add(row);   
                }
                return dt; 
            }
        }

        private void ExportDialog()
        {
            DataTable dt = DbServices.DbServices.Instance.DB_Stock.GetList().Tables["ds"];
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV files (*.csv)|*.csv";
                saveDialog.FileName = "Stock-Config.csv";

                bool flag = saveDialog.ShowDialog() == DialogResult.OK;
                if (flag)
                {
                    try
                    {
                        FileOperations.ExportCSV(headerMap, dt, saveDialog.FileName);
                        MessageBox.Show("Export complete.");
                    }
                    catch (Exception ex) 
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void ImportDialog()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Multiselect = false;
                openDialog.Filter = "CSV files (*.csv)|*.csv";
                
                bool flag = openDialog.ShowDialog() == DialogResult.OK;
                if (flag)
                {
                    try
                    { 
                        DataTable dt = ImportFromCSV(headerMap, openDialog.FileName);
                        foreach (DataRow dr in dt.Rows)
                        {
                            Debug.WriteLine(dr["NAME"]);
                        }
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void DataUpdate(int idData = 0)
        {
            try
            {
                DBM_Stock data = new DBM_Stock
                {
                    Index = int.TryParse(tb_index.Text, out var index) ? index : 0,
                    Name = tb_name.Text.ToString(),
                    RouteIn = int.TryParse(tb_routeIn.Text, out var routeIn) ? routeIn : 0,
                    RouteOut = int.TryParse(tb_routeOut.Text, out var routeOut) ? routeOut : 0,
                    LandMark = int.TryParse(tb_landMark.Text, out var landMark) ? landMark : 0,
                    EndLandMark = int.TryParse(tb_endLandMark.Text, out var endLandMark) ? endLandMark : 0,
                    Door = cbo_door.Text.ToString(),
                    Type = cbo_type.Text.ToString()
                };

                bool flag = idData != 0 && idData > 0;
                bool results;
                if (flag)
                {
                    data.Id = idData;
                    results = DbServices.DbServices.Instance.DB_Stock.Update(data);
                }
                else
                {
                    results = DbServices.DbServices.Instance.DB_Stock.Add(data) > 0;
                }

                if (results)
                {
                    ClearForm();
                    LoadData();
                    dtg_stocks.Refresh();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void V_Stocks_Load(object sender, EventArgs e)
        {
            if (dtStocks.Columns.Count == 0)
            {
                dtStocks.Columns.Add("id", typeof(int));
                dtStocks.Columns.Add("idx", typeof(int));
                dtStocks.Columns.Add("name", typeof(string));
                dtStocks.Columns.Add("routeIn", typeof(int));
                dtStocks.Columns.Add("routeOut", typeof(int));
                dtStocks.Columns.Add("mark", typeof(int));
                dtStocks.Columns.Add("endMark", typeof(int));
                dtStocks.Columns.Add("door", typeof(string));
                dtStocks.Columns.Add("type", typeof(string));
                dtStocks.Columns.Add("code", typeof(string));
            }
            dtg_stocks.DataSource = dtStocks;
            LoadData();
            dtg_stocks.Refresh();
        }

        private void dtg_stocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = Convert.ToInt32(dtg_stocks.Rows[e.RowIndex].Cells["id"].Value);

                tb_index.Text = dtg_stocks.Rows[e.RowIndex].Cells["idx"].Value.ToString();
                tb_name.Text = dtg_stocks.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tb_routeIn.Text = dtg_stocks.Rows[e.RowIndex].Cells["routeIn"].Value.ToString();
                tb_routeOut.Text = dtg_stocks.Rows[e.RowIndex].Cells["routeOut"].Value.ToString();
                tb_landMark.Text = dtg_stocks.Rows[e.RowIndex].Cells["mark"].Value.ToString();
                tb_endLandMark.Text = dtg_stocks.Rows[e.RowIndex].Cells["endMark"].Value.ToString();

                cbo_door.Text = dtg_stocks.Rows[e.RowIndex].Cells["door"].Value.ToString();
                cbo_type.Text = dtg_stocks.Rows[e.RowIndex].Cells["type"].Value.ToString();

                if (dtg_stocks.Columns[e.ColumnIndex].Name == "delete")
                {
                    int id = selectedId;
                    DialogResult dialog = MessageBox.Show($"Do you want to delete STOCK:[{id}] [{tb_name.Text}] from database?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        bool flag = DbServices.DbServices.Instance.DB_Stock.Delete(id);
                        if (flag)
                        {
                            ClearForm();
                            LoadData();
                            dtg_stocks.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);    
            }
        }
    }
}
