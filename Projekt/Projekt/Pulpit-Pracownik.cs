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
    public partial class Pulpit_Pracownik : Form
    {
        public Pracownik pracownik;
        public Pulpit_Pracownik(Pracownik p)
        {
            InitializeComponent();
            pracownik = p;
        }

        private void button_Wyloguj_Click(object sender, EventArgs e)
        {

        }

        private void button_DodajTowar_Click(object sender, EventArgs e)
        {
            Pulpit_DodajTowarcs pulpitDT = new Pulpit_DodajTowarcs(pracownik);
            pulpitDT.ShowDialog();
        }

        private void button_DodajIstTowar_Click(object sender, EventArgs e)
        {
            Pulpit_DodajIstniejacyTowar pulpitDIT = new Pulpit_DodajIstniejacyTowar (pracownik);
            pulpitDIT.ShowDialog();
        }

        private void button_UsuńTowar_Click(object sender, EventArgs e)
        {
            Pulpit_UsunTowar pulpitUT = new Pulpit_UsunTowar(pracownik);
            pulpitUT.ShowDialog();

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
                if (zlecenia[i].pracownik.id == pracownik.id)
                {
                    dataZlecenia.Rows.Add(zlecenia[i].pracownik.id, zlecenia[i].data.ToString(), zlecenia[i].towar.id, zlecenia[i].ilosc, zlecenia[i].czyPrzyjeto, zlecenia[i].informacje);
                } 
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

            for (int i = 0; i < towary.Count; i++)
            {
                dataTowary.Rows.Add(towary[i].id, towary[i].nazwa, towary[i].iloscCalegoTowaru());
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
                    if (pracownicy[i].id == pracownik.id)
                    {
                        dataGrafik.Rows.Add(pracownicy[i].id, item.Key, item.Value);
                    }
                }
            }
        }

        private void ChangePanel(Panel p)
        {
            bool ifActive = false;

            if (p.Visible == true)
                ifActive = true;

            panelZlecenia.Visible = false;
            panelTowary.Visible = false;
            panelGrafik.Visible = false;
            pictureBox1.Visible = true;

            if (ifActive == false)
            {
                p.Visible = true;
                pictureBox1.Visible = false;
            }
                
        }

        private void buttonZleceniaOdswiez_Click(object sender, EventArgs e)
        {
            WczytajZlecenia();
        }

        private void buttonTowaryOdswiez_Click(object sender, EventArgs e)
        {
            WczytajTowary();
        }

        private void buttonGrafikOdswiez_Click(object sender, EventArgs e)
        {
            WczytajGrafik();
        }

        private void button_SprawdzZlecenia_Click(object sender, EventArgs e)
        {
            ChangePanel(panelZlecenia);
        }

        private void button_SprawdzGrafik_Click(object sender, EventArgs e)
        {
            ChangePanel(panelGrafik);
        }

        private void buttonTowary_Click(object sender, EventArgs e)
        {
            ChangePanel(panelTowary);
        }

        private void Pulpit_Pracownik_Load(object sender, EventArgs e)
        {
            WczytajZlecenia();
            WczytajTowary();
            WczytajGrafik();
        }

        private void buttonZlokalizuj_Click(object sender, EventArgs e)
        {
            Pulpit_lokalizujTowar pulpitLT = new Pulpit_lokalizujTowar();
            pulpitLT.ShowDialog();
        }
    }
}
