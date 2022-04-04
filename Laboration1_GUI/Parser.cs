using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration1_GUI
{
    static class Parser
    {
        public static bool CorrectInputHour(string input)
        {
            if (Int32.TryParse(input, out int result) && result >= 0 && result < 24)
                return true;
            return false;
        }
        public static bool CorrectInputMinute(string input)
        {
            if (Int32.TryParse(input, out int result) && result >= 0 && result < 60)
                return true;
            return false;
        }
        public static void CheckInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
