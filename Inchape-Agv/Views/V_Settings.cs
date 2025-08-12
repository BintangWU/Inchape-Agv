using System.IO.Ports;

namespace Inchape_Agv.Views
{
    public partial class V_Settings : UserControl
    {
        public V_Settings()
        {
            InitializeComponent();
        }

        private void V_Settings_Load(object sender, EventArgs e)
        {
            cbo_comPort.DataSource = SerialPort.GetPortNames().ToList();
        }

        private void btn_refreshCom_Click(object sender, EventArgs e)
        {
            cbo_comPort.DataSource = SerialPort.GetPortNames().ToList();
        }
    }
}
