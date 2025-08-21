using FontAwesome.Sharp;
using DbServices.Models;
using System.Data;
using Inchape_Agv.Utilities;
using DbServices;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Inchape_Agv.Views
{
    public partial class V_Stocks : UserControl
    {
        private static DataTable dtStocks = new DataTable();
        private int idData;

        private Dictionary<string, string> headerMap = new Dictionary<string, string>
        {
            { "name", "NAME" },
            { "route", "ROUTE" },
            { "markId", "MARK" },
            { "endMarkId", "END MARK" },
            { "typeStock", "STOCK" },
            { "type", "TYPE" }
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
            tb_route.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_markId.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_endMarkId.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;

            Debug.WriteLine("Hello");
        }

        private void ClearForm()
        {
            tb_index.Clear();
            tb_name.Clear();
            tb_route.Clear();
            tb_markId.Clear();
            tb_endMarkId.Clear();

            cbo_typeStock.Text = "";
            cbo_typeStock.SelectedIndex = -1;
            cbo_type.Text = "";
            cbo_type.SelectedIndex = -1;
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
                            bool flag1 = cbo_typeStock.SelectedItem != null;
                            bool flag2 = cbo_type.SelectedItem != null;

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
                            int id = idData;
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
                    catch (Exception ex) { }
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
                    Route = int.TryParse(tb_route.Text, out var route) ? route : 0,
                    MarkId = int.TryParse(tb_markId.Text, out var markId) ? markId : 0,
                    EndMarkId = int.TryParse(tb_endMarkId.Text, out var endMarkId) ? endMarkId : 0,
                    TypeStock = cbo_typeStock.Text.ToString(),
                    Type = cbo_type.Text.ToString()
                };

                bool flag = idData != 0 && idData > 0;
                bool results;
                if (flag)
                {
                    data.ID = idData;
                    results = DbServices.DbServices.Instance.DB_Stock.Update(data);
                }
                else
                {
                    results = DbServices.DbServices.Instance.DB_Stock.Add(data) > 0;
                }

                if (results)
                {
                    ClearForm();
                    dtg_stocks.DataSource = DbServices.DbServices.Instance.DB_Stock.GetList().Tables["ds"];
                    dtg_stocks.Refresh();
                }
            }
            catch { }

        }

        private void V_Stocks_Load(object sender, EventArgs e)
        {
            dtg_stocks.DataSource = DbServices.DbServices.Instance.DB_Stock.GetList().Tables["ds"];
            dtg_stocks.Refresh();
        }

        private void dtg_stocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idData = Convert.ToInt32(dtg_stocks.Rows[e.RowIndex].Cells["id"].Value);
                //tb_index.Text = dtg_stocks.Rows[e.RowIndex].Cells["index"].Value.ToString();
                tb_name.Text = dtg_stocks.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tb_route.Text = dtg_stocks.Rows[e.RowIndex].Cells["route"].Value.ToString();
                tb_markId.Text = dtg_stocks.Rows[e.RowIndex].Cells["markId"].Value.ToString();
                tb_endMarkId.Text = dtg_stocks.Rows[e.RowIndex].Cells["endMarkId"].Value.ToString();
                cbo_typeStock.Text = dtg_stocks.Rows[e.RowIndex].Cells["typeStock"].Value.ToString();
                cbo_type.Text = dtg_stocks.Rows[e.RowIndex].Cells["type"].Value.ToString();

                if (dtg_stocks.Columns[e.ColumnIndex].Name == "delete")
                {
                    int id = idData;
                    DialogResult dialog = MessageBox.Show($"Do you want to delete STOCK:[{id}] [{tb_name.Text}] from database?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        bool flag = DbServices.DbServices.Instance.DB_Stock.Delete(id);
                        if (flag)
                        {
                            ClearForm();
                            dtg_stocks.DataSource = DbServices.DbServices.Instance.DB_Stock.GetList().Tables["ds"];
                            dtg_stocks.Refresh();
                        }
                    }
                }
            }
            catch { }
        }
    }
}
