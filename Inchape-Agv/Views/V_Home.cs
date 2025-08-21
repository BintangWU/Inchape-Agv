
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
            btn_clearProdNo.Tag = "clear";

            btn_send.Click += Button_Click;
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
                            DataTable flag = DbServices.DbServices.Instance.DB_InOutbound.InboudStock(tb_prodNo.Text);
                            //DataTable flag = DbServices.DbServices.Instance.DB_InOutbound.Outbound(tb_prodNo.Text);
                            Debug.WriteLine(flag.Rows.Count);
                            //SendToStock(tb_prodNo.Text.ToString());
                            break;

                        case "clear":
                            tb_prodNo.Clear();
                            break;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
