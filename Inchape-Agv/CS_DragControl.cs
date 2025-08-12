using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inchape_Agv
{
    [ToolboxItem(true)]
    public class CS_DragControl : Component
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private Control targetControl;

        [Browsable(true)]
        [Description("Control that will be used to drag the form.")]
        public Control SelectControl
        {
            get => targetControl;
            set => AttachControl(value);
        }

        public CS_DragControl() { } // For Toolbox

        public CS_DragControl(Control control) // For code usage
        {
            AttachControl(control);
        }

        public void AttachControl(Control control)
        {
            if (control != null)
            {
                targetControl = control;
                targetControl.MouseDown -= TargetControl_MouseDown; // prevent double attachment
                targetControl.MouseDown += TargetControl_MouseDown;
            }
        }

        private void TargetControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && targetControl != null)
            {
                ReleaseCapture();
                SendMessage(targetControl.FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
