using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Projekt
{
    static class Validate
    {
        public static bool CheckIfDate(TextBox textBox)
        {
            DateTime date = new DateTime();
            bool czySpelnia = DateTime.TryParse(textBox.Text, out date);

            if (!czySpelnia)
                textBox.BackColor = System.Drawing.Color.Crimson;
            else
                textBox.BackColor = Color.FromArgb(199, 199, 199);

            return czySpelnia;
        }

        public static bool CheckIfInt(TextBox textBox)
        {
            int value;

            bool czySpelnia = Int32.TryParse(textBox.Text, out value);

            if (!czySpelnia)
                textBox.BackColor = System.Drawing.Color.Crimson;
            else
                textBox.BackColor = Color.FromArgb(199, 199, 199);

            return czySpelnia;
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

            if (!czyLiczby)
                textBox.BackColor = System.Drawing.Color.Crimson;
            else
                textBox.BackColor = Color.FromArgb(199, 199, 199);

            return czyLiczby;
        }

        public static bool CheckIfDateAndHour(TextBox textBox)
        {
            if (!CheckIfDate(textBox))
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }
                
            
            if (textBox.Text.Length < 16)
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }

            textBox.BackColor = Color.FromArgb(199, 199, 199);
            return true;
        }

        public static bool CheckIfPositiveInt(TextBox textBox)
        {
            if (!CheckIfInt(textBox)) { 
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }

            if (Convert.ToInt32(textBox.Text) <= 0)
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }

            textBox.BackColor = Color.FromArgb(199, 199, 199);
            return true;
        }

        public static bool CheckIfString(TextBox textBox)
        {
            if (textBox.Text.Length > 50)
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }
                

            bool czyLiczby = false;
            foreach (var c in textBox.Text)
            {
                if (c > '0' || c < '9')
                {
                    czyLiczby = true;
                }
            }

            if (czyLiczby)
                textBox.BackColor = System.Drawing.Color.Crimson;
            else
                textBox.BackColor = Color.FromArgb(199, 199, 199);

            return !czyLiczby;
        }

        public static bool CheckIfPhoneNumber(TextBox textBox)
        {
            //tylko Polskie numery
            if (textBox.Text.Length != 9)
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
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

            if (!czyLiczby)
                textBox.BackColor = System.Drawing.Color.Crimson;
            else
                textBox.BackColor = Color.FromArgb(199, 199, 199);

            return czyLiczby;
        }

        public static bool CheckIfLocalization(TextBox textBox)
        {
            if (!CheckIfInt(textBox))
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }
                

            if (Convert.ToInt32(textBox.Text) > 1000)
            {
                textBox.BackColor = System.Drawing.Color.Crimson;
                return false;
            }

            textBox.BackColor = Color.FromArgb(199, 199, 199);
            return true;
        }

    }
}
