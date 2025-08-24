
using DbServices.Models;
using FontAwesome.Sharp;
using System.Data;
using System.Diagnostics;

namespace Inchape_Agv.Views
{
    public partial class V_Home : UserControl
    {
        public V_Home()
        {
            InitializeComponent();

            btn_send.Tag = "send";
            btn_test.Tag = "test";

            btn_send.Click += Button_Click;
            btn_test.Click += Button_Click;
            //tb_prodNo.KeyDown += Tb_prodNo_KeyDown;
        }

        private void Tb_prodNo_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_send.PerformClick();
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
                        case "send":
                            string prodNo = tb_prodNo.Text.ToString().Trim();
                            DataTable data = DbServices.DbServices.Instance.DB_InOutbound.InboudStock(prodNo);
                            bool flag = data != null && data.Rows.Count == 2;
                            if (flag)
                                Debug.WriteLine("Inbound Stock Success");
                            break;

                        case "clear":
                            tb_prodNo.Clear();
                            break;

                        case "test":
                            DataTable taskOrderData = DbServices.DbServices
                                .Instance.DB_TaskOrder.GetList().Tables["ds"]
                                .Select("endTime IS NULL")
                                .CopyToDataTable();

                            Debug.WriteLine(taskOrderData.Rows.Count);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void V_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
