using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class Form1 : Form
    {
        Magazyn magazyn;
        public Form1()
        {
            InitializeComponent();

            BazaDanych db = BazaDanych.UtworzBaze();
            magazyn = db.pobierzMagazyn();

        }

        private void button_Zaloguj_Click(object sender, EventArgs e)
        {
            //bool czyMenadzer = false;
            
            for (int i = 0; i < magazyn.menadzerowie.Count; i++)
            {
                if (magazyn.menadzerowie[i].login == textBox1.Text) // źle szuka hasło, powinno tylko na danym praconwiku 
                {
                    if (magazyn.menadzerowie[i].haslo == textBox2.Text)
                    {
                        Pulpit_Menadżer pulpitM = new Pulpit_Menadżer();
                        pulpitM.menadzer = magazyn.menadzerowie[i];
                        pulpitM.ShowDialog();
                        this.Hide();
                        this.Close();
                        return;
                    }

                }
            }

            for (int i = 0; i < magazyn.pracownicy.Count; i++)
            {
                if (magazyn.pracownicy[i].login==textBox1.Text)
                {
                    if (magazyn.pracownicy[i].haslo==textBox2.Text) // źle szuka hasło powinno tylko na danym menadzerze
                    {
                        Pulpit_Pracownik pulpitP = new Pulpit_Pracownik();
                        pulpitP.pracownik = magazyn.pracownicy[i];
                        pulpitP.ShowDialog();
                        this.Hide();
                        this.Close();
                        return;
                        
                    }
                }

            }
        }
    }
}
