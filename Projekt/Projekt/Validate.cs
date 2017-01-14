using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    static class Validate
    {
        public static bool CheckIfDate(TextBox textBox)
        {
            DateTime date = new DateTime();

            return DateTime.TryParse(textBox.Text, out date);
        }

        public static bool CheckIfInt(TextBox textBox)
        {
            int value;
            return Int32.TryParse(textBox.Text, out value);
        }

    }
}
