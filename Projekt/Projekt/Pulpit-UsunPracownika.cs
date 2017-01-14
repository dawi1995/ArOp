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
    public partial class Pulpit_UsunPracownika : Form
    {
        public Menadzer menadzer;
        public Pulpit_UsunPracownika(Menadzer m)
        {
            InitializeComponent();
            menadzer = m;
        }

        private void button_UsunPracownika_Click(object sender, EventArgs e)
        {
            menadzer.UsunPracownika(Convert.ToInt32(textbox_ID.Text));
        }
    }
}
