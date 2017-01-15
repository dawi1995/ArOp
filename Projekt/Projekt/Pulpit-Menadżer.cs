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
               
        public Pulpit_Menadżer(Menadzer m)
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

        private void button_ZmieńGrafik_Click(object sender, EventArgs e)
        {
            Pulpit_DodajEdytujGrafik pulpitDG = new Pulpit_DodajEdytujGrafik(menadzer);
            pulpitDG.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pulpit_EdytujGrafik pulpitEG = new Pulpit_EdytujGrafik(menadzer);
            pulpitEG.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pulpit_UsunZGrafiku pulpitUZG = new Pulpit_UsunZGrafiku(menadzer);
            pulpitUZG.ShowDialog();
        }

        private void Pulpit_Menadżer_Load(object sender, EventArgs e)
        {
            List<Pracownik> pracownicy = BazaDanych.magazyn.pracownicy;

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("imie", "Imie");
            dataGridView1.Columns.Add("nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("pesel", "PESEL");
            dataGridView1.Columns.Add("telefon", "Numer telefonu");
            dataGridView1.Columns.Add("dataurodzenia", "Data urodzenia");


            for (int i = 0; i < pracownicy.Count; i++)
            {
                dataGridView1.Rows.Add(pracownicy[i].id, pracownicy[i].imie, pracownicy[i].nazwisko, pracownicy[i].pesel, pracownicy[i].telefon, pracownicy[i].dataUrodzenia.ToString());
            }
        }

        private void button_pokazPracownikow_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
                panel2.Visible = true;
            else
                panel2.Visible = false;
        }
    }
}
