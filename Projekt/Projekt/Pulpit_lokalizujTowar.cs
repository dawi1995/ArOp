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
    public partial class Pulpit_lokalizujTowar : Form
    {
        public Pulpit_lokalizujTowar()
        {
            InitializeComponent();
        }

        private void button_lokalizuj_Click(object sender, EventArgs e)
        {
            bool czyWaliduje = true;

            if (!Projekt.Validate.CheckIfPositiveInt(textBox_idtowaru))
                czyWaliduje = false;

            if (czyWaliduje == true)
            {
                int id;
                bool czyInt = Int32.TryParse(textBox_idtowaru.Text, out id);

                if (czyInt == false)
                {
                    Komunikaty.WyświetlKomunikat("Podaj id we właściwym formacie");
                    return;
                }

                Towar szukany = BazaDanych.magazyn.towary.Find(Towar => Towar.id == id);
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                if (szukany == null)
                {
                    Komunikaty.WyświetlKomunikat("Szukanego towaru nie ma w magazynie.");
                    return;
                }

                dataGridView1.Columns.Add("sektor", "Sektor");
                dataGridView1.Columns.Add("rzad", "Rząd");
                dataGridView1.Columns.Add("polka", "Półka");
                dataGridView1.Columns.Add("ilosc", "Ilość");


                foreach (var item in szukany.lokalizacje)
                {
                    dataGridView1.Rows.Add(item.Key.sektor, item.Key.rzad, item.Key.polka, item.Value);
                }

                if (Height < 400)
                {
                    Height = 410;
                }
                return;
            }
            Komunikaty.NieprawidlowaWalidacja();



        }
    }
}
