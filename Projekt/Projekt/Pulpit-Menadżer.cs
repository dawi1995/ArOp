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
            dataZlecenia.DataSource = null;
            dataZlecenia.Columns.Clear();
            dataZlecenia.Rows.Clear();

            List<Zlecenie> zlecenia = BazaDanych.magazyn.zlecenia;

            dataZlecenia.Columns.Add("idpracownika", "ID pracownika");
            dataZlecenia.Columns.Add("data", "Data");
            dataZlecenia.Columns.Add("idtowaru", "ID towaru");
            dataZlecenia.Columns.Add("ilsoc", "Ilość towaru");
            dataZlecenia.Columns.Add("czyPrzyjeto", "Czy przyjęto");
            dataZlecenia.Columns.Add("informacja", "Informacja");


            for (int i = 0; i < zlecenia.Count; i++)
            {
                dataZlecenia.Rows.Add(zlecenia[i].pracownik.id, zlecenia[i].data.ToString(), zlecenia[i].towar.id, zlecenia[i].ilosc, zlecenia[i].czyPrzyjeto, zlecenia[i].informacje);
            }
        }

        private void WczytajTowary()
        {
            dataTowary.DataSource = null;
            dataTowary.Columns.Clear();
            dataTowary.Rows.Clear();

            List<Towar> towary = BazaDanych.magazyn.towary;

            dataTowary.Columns.Add("idtowaru", "ID Towaru");
            dataTowary.Columns.Add("nazwa", "Nazwa");
            dataTowary.Columns.Add("ilosc", "Ilość towaru w magazynie");

            int ilosc = 0;

            for (int i = 0; i < towary.Count; i++)
            {
                dataZlecenia.Rows.Add(towary[i].id, towary[i].nazwa, towary[i].iloscCalegoTowaru());
            }
        }

        private void WczytajGrafik()
        {
            dataGrafik.DataSource = null;
            dataGrafik.Columns.Clear();
            dataGrafik.Rows.Clear();

            List<Pracownik> pracownicy = BazaDanych.magazyn.pracownicy;

            dataGrafik.Columns.Add("idpracownika", "ID pracownika");
            dataGrafik.Columns.Add("data", "Data");
            dataGrafik.Columns.Add("godziny", "Liczba godzin");


            for (int i = 0; i < pracownicy.Count; i++)
            {
                foreach (var item in pracownicy[i].grafik.grafik)
                {
                    dataGrafik.Rows.Add(pracownicy[i].id, item.Key, item.Value);
                }
            }
        }

        private void Pulpit_Menadżer_Load(object sender, EventArgs e)
        {
            WczytajPracowników();
            WczytajZlecenia();
            WczytajGrafik();
            WczytajTowary();
        }

       

        private void button_pracownicyOdswiez_Click(object sender, EventArgs e)
        {
            WczytajPracowników();
        }

        private void buttonZleceniaOdswiez_Click(object sender, EventArgs e)
        {
            WczytajZlecenia();
        }

        private void buttonGrafikOdswiez_Click(object sender, EventArgs e)
        {
            WczytajGrafik();
        }

        private void buttonTowaryOdswiez_Click(object sender, EventArgs e)
        {
            WczytajTowary();
        }

        private void ChangePanel(Panel p)
        {
            bool ifActive = false;

            if (p.Visible == true)
                ifActive = true;

            panelPracownicy.Visible = false;
            panelZlecenia.Visible = false;
            panelTowary.Visible = false;
            panelGrafik.Visible = false;

            if (ifActive == false)
                p.Visible = true;
        }

        private void ChangePanelState(object sender, EventArgs e)
        {
            ChangePanel(sender as Panel);
        }

        
    }
}
