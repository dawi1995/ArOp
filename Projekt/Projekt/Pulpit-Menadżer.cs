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
    public partial class Pulpit_Menadżer : Form
    {
        public Menadzer menadzer;
        public Magazyn magazyn;
        public BazaDanych db;
        
        public Pulpit_Menadżer(Menadzer m, Magazyn mag, BazaDanych db)
        {
            InitializeComponent();
            menadzer = m;
            magazyn = mag;
            this.db = db;
        }

        private void button_DodajEdytujPracownika_Click(object sender, EventArgs e)
        {
            Pulpit_DodajEdytujPracownika pulpitDEP = new Pulpit_DodajEdytujPracownika(menadzer, magazyn, db);
            pulpitDEP.ShowDialog();
        }

        private void button_UsunPracownika_Click(object sender, EventArgs e)
        {
            Pulpit_UsunPracownika pulpitUP = new Pulpit_UsunPracownika(menadzer,magazyn,db);
            pulpitUP.ShowDialog();
        }

        private void button_ZmieńGrafik_Click(object sender, EventArgs e)
        {
            Pulpit_DodajEdytujGrafik pulpitDG = new Pulpit_DodajEdytujGrafik(menadzer);
            pulpitDG.ShowDialog();
        }
    }
}
