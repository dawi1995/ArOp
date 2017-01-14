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
    public partial class Pulpit_Pracownik : Form
    {
        public Pracownik pracownik;
        public Pulpit_Pracownik()
        {
            InitializeComponent();
        }

        private void button_Wyloguj_Click(object sender, EventArgs e)
        {

        }

        private void button_DodajTowar_Click(object sender, EventArgs e)
        {
            Pulpit_DodajTowarcs pulpitDT = new Pulpit_DodajTowarcs(pracownik);
            pulpitDT.ShowDialog();
        }

        private void button_DodajIstTowar_Click(object sender, EventArgs e)
        {
            Pulpit_DodajIstniejacyTowar pulpitDIT = new Pulpit_DodajIstniejacyTowar (pracownik);
            pulpitDIT.ShowDialog();
        }

        private void button_UsuńTowar_Click(object sender, EventArgs e)
        {
            Pulpit_UsunTowar pulpitUT = new Pulpit_UsunTowar(pracownik);
            pulpitUT.ShowDialog();

        }
    }
}
