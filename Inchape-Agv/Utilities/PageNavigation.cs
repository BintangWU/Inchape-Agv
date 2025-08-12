using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchape_Agv.Utilities
{
    public class PageNavigation
    {
        private UserControl _userControl;
        private Panel _panel;

        public PageNavigation(Panel panel)
        {
            _panel = panel;
        }

        public void OpenUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();

            _panel.Controls.Clear();
            _panel.Controls.Add(userControl);
        }
    }
}
