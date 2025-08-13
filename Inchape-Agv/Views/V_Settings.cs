using FontAwesome.Sharp;
using Microsoft.AspNetCore.Builder;
using System.IO.Ports;
using Inchape_Agv.Utilities;
using Inchape_Agv.Utilities.SysConfig;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

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

            tb_rfAddr.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            tb_serverPort.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
            cbo_baud.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
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
            SysConfigModel config = SysConfig.Load();

            if (config != null)
            {
                cbo_comPort.SelectedText = config.ComPort.ToString().ToUpper();
                cbo_baud.SelectedText = Convert.ToString(config.Baudrate);
                tb_rfAddr.Text = Convert.ToString(config.WirelessAddr);
                tb_serverPort.Text = Convert.ToString(config.ServerPort);
            }
            else
            {
                cbo_comPort.DataSource = SerialPort.GetPortNames().ToList();
            }
        }
    }
}
