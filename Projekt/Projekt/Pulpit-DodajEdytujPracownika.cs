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
        public Pulpit_DodajEdytujPracownika(Menadzer m)
        {
            InitializeComponent();
            menadzer = m;            
        }

        private void button_DodajPracownika_Click(object sender, EventArgs e)
        {
            bool czyWaliduje = true;

            if (!Projekt.Validate.CheckIfPositiveInt(textBox_ID))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfString(textBox_imie))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfString(textBox_nazwisko))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfPesel(textBox_PESEL))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfDate(textBox_date))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfPhoneNumber(textBox_telefon))
                czyWaliduje = false;

            if (czyWaliduje == true)
            {
                menadzer.DodajPracownika(Convert.ToInt32(textBox_ID.Text), textBox_imie.Text, textBox_nazwisko.Text, textBox_PESEL.Text, Convert.ToInt32(textBox_telefon.Text), Convert.ToDateTime(textBox_date.Text));
                //menadzer.DodajPracownika(Convert.ToInt32(textBox_ID.Text),textBox_imie.Text,textBox_nazwisko.Text,textBox_PESEL.Text,Convert.ToInt32(textBox_telefon.Text),Convert.ToDateTime(textBox_date.Text),magazyn,bd,"login","haslo");
                return;
            }
            Komunikaty.NieprawidlowaWalidacja();
        }

        private void button_EdytujPracownika_Click(object sender, EventArgs e)
        {

        }
    }
}
