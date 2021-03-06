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
    public partial class Pulpit_EdytujGrafik : Form
    {
        Menadzer menadzer;
        public Pulpit_EdytujGrafik(Menadzer m)
        {
            menadzer = m;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool czyWaliduje = true;

            if (!Projekt.Validate.CheckIfPositiveInt(textBox_idpracownika))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfDateAndHour(textBox_datadozmiany))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfDateAndHour(textBox_nowadata))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfPositiveInt(textBox_czaspracy))
                czyWaliduje = false;

            if (czyWaliduje == true)
            {
                menadzer.EdytujGrafik(Convert.ToInt32(textBox_idpracownika.Text), Convert.ToDateTime(textBox_datadozmiany.Text), Convert.ToDateTime(textBox_nowadata.Text), Convert.ToInt32(textBox_czaspracy.Text));
                return;
            }
            Komunikaty.NieprawidlowaWalidacja();
               
        }
    }
}
