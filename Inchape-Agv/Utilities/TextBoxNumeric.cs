using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchape_Agv.Utilities
{
    public static class TextBoxNumeric
    {
        public static void NumericOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void NumericComa_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., Backspace, Delete, arrows, etc.)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Allow comma
            if (e.KeyChar == ',')
            {
                return;
            }

            // Otherwise block the input
            e.Handled = true;
        }
    }
}
