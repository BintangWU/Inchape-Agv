
using FontAwesome.Sharp;

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

                            break;

                        case "clear":
                            tb_prodNo.Clear();
                            break;
                    }
                }
            }
            catch { }
        }

        private void SendToStock(string prodNo)
        {

        }
    }
}
