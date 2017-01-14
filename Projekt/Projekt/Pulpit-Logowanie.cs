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
            
            
            for (int i = 0; i < magazyn.menadzerowie.Count; i++)
            {
                if (magazyn.menadzerowie[i].login == textBox1.Text) 
                {
                    string haslo = magazyn.menadzerowie[i].haslo;
                    if (textBox2.Text==haslo)
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
                    string haslo = magazyn.pracownicy[i].haslo;
                    if (textBox2.Text==haslo) 
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

            MessageBox.Show("Podano błedne dane logowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

         
        }

        
    }
}
