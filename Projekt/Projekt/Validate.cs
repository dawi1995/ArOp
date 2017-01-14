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

        public static bool CheckIfPesel(TextBox textBox)
        {
            if (textBox.Text.Length != 11)
            {
                return false;
            }

            bool czyLiczby = true;
            foreach (var c in textBox.Text)
            {
                if (c < '0' || c > '9')
                {
                    czyLiczby = false;
                }
            }

            return czyLiczby;
        }

    }
}
