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
        public static bool CheckIfDateAndHour(TextBox textBox)
        {
            if (!CheckIfDate(textBox))
                return false;
            
            if (textBox.Text.Length < 16)
                return false;
            
            return true;
        }
        public static bool CheckIfPositiveInt(TextBox textBox)
        {
            if (!CheckIfInt(textBox))
                textBox.BackColor = System.Drawing.Color.Red;
                return false;

            if (Convert.ToInt32(textBox.Text) <= 0)
                textBox.BackColor = System.Drawing.Color.Red;
                return false;

            return true;
        }
        public static bool CheckIfString(TextBox textBox)
        {
            if (textBox.Text.Length > 50)
                return false;

            bool czyLiczby = false;
            foreach (var c in textBox.Text)
            {
                if (c > '0' || c < '9')
                {
                    czyLiczby = true;
                }
            }
            return !czyLiczby;
        }
        public static bool CheckIfPhoneNumber(TextBox textBox)
        {
            if (textBox.Text.Length != 9) //tylko Polskie numery
                return false;

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
        public static bool CheckIfLocalization(TextBox textBox)
        {
            if (!CheckIfInt(textBox))
                return false;

            if (Convert.ToInt32(textBox.Text) > 1000)
                return false;

            return true;
        }

    }
}
