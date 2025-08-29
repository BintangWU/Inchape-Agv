
using CarServices;
using DbServices;
using DbServices.Fuctions;
using DbServices.Models;
using FontAwesome.Sharp;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace Inchape_Agv.Views
{
    public partial class V_Home : UserControl
    {
        public V_Home()
        {
            InitializeComponent();

            btn_send.Tag = "send";
            btn_car.Tag = "car";
            btn_outTest.Tag = "outbound";

            btn_send.Click += Button_Click;
            btn_car.Click += Button_Car_Click;
            btn_outTest.Click += Button_OutBound_Click;
            //tb_prodNo.KeyDown += Tb_prodNo_KeyDown;
        }

        private void Button_Car_Click(object? sender, EventArgs e)
        {
            try
            {
                DBM_TaskOrder taskOrder = DbServices.DbServices
                    .Instance.DB_TaskOrder.ToModel(DbServices.DbServices.Instance.DB_TaskOrder
                    .GetList("WHERE (status = 'Queue' OR status = 'Process') " +
                    "AND (LH IS NULL OR LH = '' OR LH = False OR RH IS NULL OR RH = '' OR RH = False) " +
                    "ORDER BY id ASC LIMIT 1").Tables["ds"].Rows[0]);

                int[] routes = taskOrder.Routes.ToString()
                    .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                Debug.WriteLine($"Release the Car to route for {taskOrder.CallType}: " +
                    $"[{routes[0]}] [{taskOrder.ProdNo}->{taskOrder.Destination}]");

                taskOrder.Status = "Process";
                taskOrder.LH = true;
                DbServices.DbServices.Instance.DB_TaskOrder.Update(taskOrder);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void Button_OutBound_Click(object? sender, EventArgs e)
        {
            string prodNo = "";
            string message = "";

            try
            {
                prodNo = tb_outBound.Text.ToString();
                DataTable data = DbServices.DbServices.Instance.DB_InOutbound.Outbound(prodNo);
                bool flag = data != null && data.Rows.Count == 2;
                if (flag)
                    message = $"Outbound Stock Success [{prodNo}]";
                else
                    message = $"[{prodNo}] not found, please check your production code!";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            Debug.WriteLine(message);
            tb_outBound.Clear();
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
                            string message = "";
                            DataTable data = null;

                            try
                            {
                                string prodNo = tb_prodNo.Text.ToString().Trim();
                                data = DbServices.DbServices.Instance.DB_InOutbound.InboudStock(prodNo);
                                bool flag = data != null && data.Rows.Count == 2;
                                if (flag)
                                    message = $"Inbound Stock Success [{prodNo}]";
                            }
                            catch (Exception ex)
                            {
                                message = ex.Message;
                            }
                            Debug.WriteLine(message);
                            tb_prodNo.Clear();
                            break;

                        case "clear":
                            tb_prodNo.Clear();
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
