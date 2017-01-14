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
    public partial class Pulpit_UsunZGrafiku : Form
    {
        Menadzer menadzer;
        public Pulpit_UsunZGrafiku(Menadzer m)
        {
            menadzer = m;
            InitializeComponent();
        }

        private void button_UsunZGrafiku_Click(object sender, EventArgs e)
        {
            menadzer.UsunZGrafiku(Convert.ToInt32(textBox_idracownika.Text), Convert.ToDateTime(textBox_dataDoUsuniecia.Text));
        }
    }
}
