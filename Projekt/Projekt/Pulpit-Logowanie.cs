﻿using System;
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
        BazaDanych db;
        public Form1()
        {
            InitializeComponent();

            db = BazaDanych.UtworzBaze();
            magazyn = db.pobierzMagazyn();
            //db.WykonajWBazie("INSERT INTO pracownicy2(id, imie, nazwisko, pesel, telefon, dataurodzenia, login, haslo) VALUES(122, 'Dawid', 'Brze', '12345678901', 111222333, '19921229', 'login', 'haslo');");

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
                        Pulpit_Menadżer pulpitM = new Pulpit_Menadżer(db.ZwrocMenadzera(magazyn.menadzerowie[i].id),magazyn,db);
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

            MessageBox.Show("Podano błedne dane logowania");
            return;

            
        }

        
    }
}
