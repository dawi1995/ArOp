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

        private void WczytajPracowników()
        {
            dataPracownicy.DataSource = null;
            dataPracownicy.Columns.Clear();
            dataPracownicy.Rows.Clear();

            List<Pracownik> pracownicy = BazaDanych.magazyn.pracownicy;

            dataPracownicy.Columns.Add("id", "ID");
            dataPracownicy.Columns.Add("imie", "Imie");
            dataPracownicy.Columns.Add("nazwisko", "Nazwisko");
            dataPracownicy.Columns.Add("pesel", "PESEL");
            dataPracownicy.Columns.Add("telefon", "Numer telefonu");
            dataPracownicy.Columns.Add("dataurodzenia", "Data urodzenia");


            for (int i = 0; i < pracownicy.Count; i++)
            {
                dataPracownicy.Rows.Add(pracownicy[i].id, pracownicy[i].imie, pracownicy[i].nazwisko, pracownicy[i].pesel, pracownicy[i].telefon, pracownicy[i].dataUrodzenia.ToString("dd-MM-yyyy"));
            }
        }

        private void WczytajZlecenia()
        {
            dataPracownicy.DataSource = null;
            dataPracownicy.Columns.Clear();
            dataPracownicy.Rows.Clear();

            List<Zlecenie> zlecenia = BazaDanych.magazyn.zlecenia;

            dataPracownicy.Columns.Add("idpracownika", "ID pracownika");
            dataPracownicy.Columns.Add("data", "Data");
            dataPracownicy.Columns.Add("idtowaru", "ID towaru");
            dataPracownicy.Columns.Add("ilsoc", "Ilość towaru");
            dataPracownicy.Columns.Add("czyPrzyjeto", "Czy przyjęto");
            dataPracownicy.Columns.Add("informacja", "Informacja");


            for (int i = 0; i < zlecenia.Count; i++)
            {
                dataPracownicy.Rows.Add(zlecenia[i].pracownik.id, zlecenia[i].data.ToString(), zlecenia[i].ilosc, zlecenia[i].czyPrzyjeto, zlecenia[i].informacje);
            }
        }

        private void Pulpit_Menadżer_Load(object sender, EventArgs e)
        {
            WczytajPracowników();
        }

        private void button_pokazPracownikow_Click(object sender, EventArgs e)
        {
            if (panelPracownicy.Visible == false)
                panelPracownicy.Visible = true;
            else
                panelPracownicy.Visible = false;
        }

        private void button_pracownicyOdswiez_Click(object sender, EventArgs e)
        {
            WczytajPracowników();
        }

        private void buttonZlecenia_Click(object sender, EventArgs e)
        {
            if (panelZlecenia.Visible == false)
                panelZlecenia.Visible = true;
            else
                panelZlecenia.Visible = false;
        }

        private void buttonZleceniaOdswiez_Click(object sender, EventArgs e)
        {
            WczytajZlecenia();
        }
    }
}
