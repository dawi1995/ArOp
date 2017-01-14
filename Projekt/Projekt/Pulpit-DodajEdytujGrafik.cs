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
    public partial class Pulpit_DodajEdytujGrafik : Form
    {
        Menadzer menadzer;
        public Pulpit_DodajEdytujGrafik(Menadzer m)
        {
            menadzer = m;
            InitializeComponent();
        }

        private void button_DodajEdytujGrafik_Click(object sender, EventArgs e)
        {
            menadzer.DodajDoGrafiku(Convert.ToInt32(textBox_idpracownika.Text), Convert.ToDateTime(textBox_Data.Text), Convert.ToInt32(textBox_LiczbaGodzin.Text));

        }
    }
}
