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
        public Form1()
        {
            InitializeComponent();

            BazaDanych.UtworzBaze();
        }

        private void button_Zaloguj_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < BazaDanych.magazyn.menadzerowie.Count; i++)
            {
                if (BazaDanych.magazyn.menadzerowie[i].login == textBox1.Text) 
                {
                    string haslo = BazaDanych.magazyn.menadzerowie[i].haslo;
                    if (textBox2.Text==haslo)
                    {
                        Pulpit_Menadżer pulpitM = new Pulpit_Menadżer(BazaDanych.ZwrocMenadzera(BazaDanych.magazyn.menadzerowie[i].id), BazaDanych.magazyn,db);
                        pulpitM.menadzer = BazaDanych.magazyn.menadzerowie[i];
                        pulpitM.ShowDialog();
                        this.Hide();
                        this.Close();
                        return;
                    }

                }
            }

            for (int i = 0; i < BazaDanych.magazyn.pracownicy.Count; i++)
            {
                if (BazaDanych.magazyn.pracownicy[i].login==textBox1.Text)
                {
                    string haslo = BazaDanych.magazyn.pracownicy[i].haslo;
                    if (textBox2.Text==haslo) 
                    {
                        Pulpit_Pracownik pulpitP = new Pulpit_Pracownik();
                        pulpitP.pracownik = BazaDanych.magazyn.pracownicy[i];
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
