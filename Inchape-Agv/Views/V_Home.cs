
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
                            CarServices.CarControl.Instance.CarAddStock(tb_prodNo.Text.ToString());
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

        private bool SendToStock(string prodNo)
        {
            bool result = false;
            DataTable dt = DbServices.DbServices.Instance.DB_Stock.GetList("WHERE (prodNo IS NULL OR prodNo='-' OR prodNo='') " +
                "AND typeStock= 'FG' " +
                "AND type IN ('LH', 'RH') " +
                "ORDER BY idx ASC, type ASC LIMIT 2").Tables["ds"];

            bool flag = dt.Rows.Count == 2;
            if (flag)
            {
                int i = 0;
                string stockName = "";
                string[] stockListName = new string[2];

                foreach (DataRow dr in dt.Rows)
                {
                    stockListName[i] = dr["name"].ToString();
                    i++;
                }

                bool flag2 = stockListName[0] == stockListName[1];
                if (flag2)
                {
                    stockName = stockListName[0].ToString();
                    DBM_TaskOrder data = new DBM_TaskOrder
                    {
                        ProdNo = prodNo.ToString().ToUpper(),
                        Status = "Stock",
                        StartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    };

                    bool flag3 = DbServices.DbServices.Instance.DB_Stock.Update(stockName, prodNo);
                    int flag4 = DbServices.DbServices.Instance.DB_TaskOrder.Add(data);

                    bool flag5 = (flag3 && (flag4 > 0));
                    string msgBox = (flag5 ? "Success" : "Failed") + " send ";
                    msgBox += $"[{tb_prodNo.Text.ToString().ToUpper()}]";
                    DialogResult dialog = MessageBox.Show(msgBox, "Question", MessageBoxButtons.YesNo);
                                        
                    result = true;
                }
                else
                    result = false;
            }
            return result;
        }
    }
}
