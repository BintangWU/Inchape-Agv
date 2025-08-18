using FontAwesome.Sharp;
using Microsoft.AspNetCore.Builder;
using System.IO.Ports;
using Inchape_Agv.Utilities;
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
            btn_save.Tag = "save";

            btn_refreshCom.Click += Button_Clik;
            btn_apply.Click += Button_Clik;
            btn_save.Click += Button_Clik;

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

                        case "save":
                            SysConfigModel model = new SysConfigModel
                            {
                                ComPort = cbo_comPort.Text.ToString().ToUpper(),
                                Baudrate = int.TryParse(cbo_baud.Text, out var baudrate) ? baudrate : 0,
                                WirelessAddr = int.TryParse(tb_rfAddr.Text, out var wireless) ? wireless : 0, 
                                ServerPort = int.TryParse(tb_serverPort.Text, out var server) ? server : 0
                            };
                            bool flag = SysConfig.Save(model);
                            string message = flag ? "Save complete!" : " Failed save file";
                            MessageBox.Show($"{message}", "Information", MessageBoxButtons.OK);

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
                cbo_comPort.SelectedItem = config.ComPort.ToString().ToUpper();
                cbo_baud.SelectedItem = config.Baudrate.ToString();
                tb_rfAddr.Text = config.WirelessAddr.ToString();
                tb_serverPort.Text = config.ServerPort.ToString();
            }
            else
            {
                cbo_comPort.DataSource = SerialPort.GetPortNames().ToList();
            }
        }
    }
}
