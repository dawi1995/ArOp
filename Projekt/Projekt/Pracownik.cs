using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
   public class Pracownik : CzlonekFirmy
    {
        public Grafik grafik;


        public Pracownik() {
            grafik = new Grafik();

        }
        public Pracownik(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, string login, string haslo)
            : base(id, imie, nazwisko,pesel, telefon, dataUrodzenia, login, haslo) {
            grafik = new Grafik();
        }
        public void UsunTowarZPolki(int id, int sektor, int rzad, int polka)
        {

        }
        public void UsunTowar(int id)
        {
        }
        public void DodajIstniejacyTowar(int id, int sektor, int rzad, int polka)
        {
            /*
            if (BazaDanych.magazyn.towary.Contains(id) != null)
            {
                MessageBox.Show("Towar o takim ID już istnieje.");
                return "";
            }

            string login = imie.ToLower();
            string haslo = nazwisko.ToLower();
            Pracownik p = new Pracownik(id, imie, nazwisko, pesel, telefon, rokUrodzenia, login, haslo);
            BazaDanych.magazyn.pracownicy.Add(p);

            return String.Format("INSERT INTO pracownicy2 (id, imie, nazwisko, pesel, telefon, dataurodzenia, login, haslo) VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}{6}{7}', '{8}', '{9}');", id, imie, nazwisko, pesel, telefon, rokUrodzenia.Year, rokUrodzenia.Month, rokUrodzenia.Day, login, haslo);
            */
        }
        public void DodajNowyTowar(string nazwa, int id, int sektor, int rzad, int polka)
        {
        }
    }
}
