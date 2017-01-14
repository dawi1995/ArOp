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
    public partial class Pulpit_DodajTowarcs : Form
    {
        Pracownik pracownik;
        public Pulpit_DodajTowarcs(Pracownik p)
        {
            InitializeComponent();
            pracownik = p; 
        }

        private void button_DodajNowyTowar_Click(object sender, EventArgs e)
        {
            pracownik.DodajNowyTowar(textBox_nazwatowaru.Text, Convert.ToInt32(textBox_idtowaru.Text), Convert.ToInt32(textBox_sektor.Text), Convert.ToInt32(textBox_rzad.Text), Convert.ToInt32(textBox_polka.Text), Convert.ToInt32(textBox_ilosc.Text));
        }
    }
}
