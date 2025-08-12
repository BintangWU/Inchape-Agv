using FontAwesome.Sharp;
using Microsoft.AspNetCore.Builder;
using System.IO.Ports;

namespace Inchape_Agv.Views
{
    public partial class V_Settings : UserControl
    {
        public V_Settings()
        {
            InitializeComponent();

            btn_refreshCom.Tag = "comList";
            btn_apply.Tag = "apply";

            btn_refreshCom.Click += Button_Clik;
            btn_apply.Click += Button_Clik;
        }

        private void Button_Clik(object? sender, EventArgs e)
        {
            try
            {
                if (sender is IconButton btn)
                {
                    string action = btn.Tag?.ToString() ?? "";
                    switch (action) {
                        case "comList":
                            cbo_comPort.DataSource = SerialPort.GetPortNames().ToList();
                            break;

                        case "apply":
                            DialogResult result = MessageBox.Show("Do you want to apply this config?, need to RESTART the application now!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes) {
                                Application.Restart();
                                Environment.Exit(0);    
                            }
                            break;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void V_Settings_Load(object sender, EventArgs e)
        {
            cbo_comPort.DataSource = SerialPort.GetPortNames().ToList();
        }
    }
}
