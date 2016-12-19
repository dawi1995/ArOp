using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BazaDanych db = new BazaDanych(@"DESKTOP-FE8VDHN\SQLEXPRESS", "hurtownia");
            Magazyn magazyn = db.pobierzMagazyn();

        }

        private void button_Zaloguj_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                
                //this.Hide();
                Pulpit_Menadżer MenedzerForm = new Pulpit_Menadżer();
                MenedzerForm.Show();
                
                this.Close();

            }
            else
            {
                //this.Hide();
                Pulpit_Pracownik PracownikForm = new Pulpit_Pracownik();
                PracownikForm.Show();
                this.Close();
            }

        }
    }
}
