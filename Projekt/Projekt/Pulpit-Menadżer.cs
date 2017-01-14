﻿using System;
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
               
        public Pulpit_Menadżer(Menadzer m, Magazyn mag, BazaDanych db)
        {
            InitializeComponent();
            menadzer = m;
        }

        private void button_DodajEdytujPracownika_Click(object sender, EventArgs e)
        {
            Pulpit_DodajEdytujPracownika pulpitDEP = new Pulpit_DodajEdytujPracownika(menadzer);
            pulpitDEP.ShowDialog();
        }

        private void button_UsunPracownika_Click(object sender, EventArgs e)
        {
            Pulpit_UsunPracownika pulpitUP = new Pulpit_UsunPracownika(menadzer);
            pulpitUP.ShowDialog();
        }
    }
}
