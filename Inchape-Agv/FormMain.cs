using FontAwesome.Sharp;
using Inchape_Agv.Utilities;
using Inchape_Agv.Views;
using System.Diagnostics;
using System.Windows;
using APIService;


namespace Inchape_Agv
{
    public partial class FormMain : Form
    {
        private PageNavigation _navigate;
        private bool _panelBtnStock = false;
        public FormMain()
        {
            InitializeComponent();
            _navigate = new PageNavigation(pnl_content);

            btn_home.Tag = new V_Home();
            btn_task.Tag = new V_Tasks();
            btn_stock.Tag = new V_Stocks();
            btn_config.Tag = new V_Settings();

            btn_home.Click += MenuButton_Click;
            btn_task.Click += MenuButton_Click;
            btn_stock.Click += MenuButton_Click;
            btn_config.Click += MenuButton_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                System.Windows.MessageBox.Show("Don't Run multiple instance!\r\nMaybe Check task manager if this application running on background", 
                    "Error", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }

            SysConfigModel cfg = SysConfig.Load();
            bool flag = CarServices.CarControl.Instance.InitialCommunication(
                cfg.ComPort.ToString().ToUpper(),
                cfg.Baudrate);

            if (!flag)
            {
                System.Windows.MessageBox.Show($"{cfg.ComPort} with {cfg.Baudrate} can't open!, please check the port",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            else
            {
                CarServices.CarControl.Instance.InitialCarSystem(cfg.WirelessAddr, cfg.HomeMark);
            }

            HttpAPI.Instance.StartAPI(cfg.ServerPort);
            _navigate.OpenUserControl(new V_Home());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuButton_Click(object? sender, EventArgs e)
        {
            if (sender is IconButton btn)
            {
                if (btn.Tag is UserControl instance)
                {
                    _navigate.OpenUserControl(instance);
                    var method = instance.GetType().GetMethod("LoadData");
                    method?.Invoke(instance, null);
                }
            }
        }
    }
}
