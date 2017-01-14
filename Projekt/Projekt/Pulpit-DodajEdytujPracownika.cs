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
    
    public partial class Pulpit_DodajEdytujPracownika : Form
    {
        public Menadzer menadzer;
        public Magazyn magazyn;
        public BazaDanych bd;
        public Pulpit_DodajEdytujPracownika(Menadzer m, Magazyn mag, BazaDanych bd)
        {
            InitializeComponent();
            menadzer = m;
            magazyn = mag;
            this.bd = bd;
            
        }

        private void button_DodajPracownika_Click(object sender, EventArgs e)
        {

            bd.WykonajWBazie(menadzer.DodajPracownika(Convert.ToInt32(textBox_ID.Text), textBox_imie.Text, textBox_nazwisko.Text, textBox_PESEL.Text, Convert.ToInt32(textBox_telefon.Text), Convert.ToDateTime(textBox_date.Text), magazyn, (BazaDanych)bd, textBox_imie.Text, textBox_nazwisko.Text));
            //menadzer.DodajPracownika(Convert.ToInt32(textBox_ID.Text),textBox_imie.Text,textBox_nazwisko.Text,textBox_PESEL.Text,Convert.ToInt32(textBox_telefon.Text),Convert.ToDateTime(textBox_date.Text),magazyn,bd,"login","haslo");
          
        }

        private void button_EdytujPracownika_Click(object sender, EventArgs e)
        {

        }
    }
}
