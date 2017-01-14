using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public class Menadzer : CzlonekFirmy
    {
        public Menadzer() { }

        public Menadzer(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, Magazyn magazyn, string login, string haslo)
            : base(id, imie, nazwisko, pesel, telefon, dataUrodzenia, login, haslo) { }

        public string DodajPracownika(int id, string imie, string nazwisko, string pesel, int telefon, DateTime rokUrodzenia) //do uzupełnienia
        {
            if (BazaDanych.ZwrocPracownika(id) != null)
            {
                MessageBox.Show("Pracownik o takim ID już istnieje.");
                return "";
            }

            string login = imie.ToLower();
            string haslo = nazwisko.ToLower();
            Pracownik p = new Pracownik(id, imie, nazwisko, pesel, telefon, rokUrodzenia, login, haslo);
            BazaDanych.magazyn.pracownicy.Add(p);

            return String.Format("INSERT INTO pracownicy2 (id, imie, nazwisko, pesel, telefon, dataurodzenia, login, haslo) VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}{6}{7}', '{6}', '{7}');", id, imie, nazwisko, pesel, telefon, rokUrodzenia.Year, rokUrodzenia.Month, rokUrodzenia.Day, login, haslo );
        }

        public string DodajDoGrafiku(int id, DateTime data, int liczbaGodzin) //+ do sprawdzenia
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);

            if (p != null && !p.grafik.CzyDataJestWGrafiku(data))
            {
                p.grafik.DodajDoGrafiku(data, liczbaGodzin);
                return String.Format("INSERT INTO grafik (id, dzien, czas) values ({0}, '{1}{2}{3} {4}', {5});", id, data.Year, data.Month, data.Day, liczbaGodzin);
            }

            MessageBox.Show("Praownik o podanym ID nie istnieje lub podana data jest już wpisana do grafiku.");
            return "";
        }

        public string  EdytujGrafik(int id, DateTime dataDoZmiany, DateTime nowaData, int liczbaGodzin) // + do sprawdzenia
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);

            if (p!= null && p.grafik.CzyDataJestWGrafiku(dataDoZmiany))
            {
                p.grafik.EdytujGrafik(dataDoZmiany, nowaData, liczbaGodzin);
                return String.Format("UPDATE grafik SET dzien='{0}{1}{2} {3}', czas={4} WHERE (id={5} AND dzien='{6}{7}{8} {9}');", nowaData.Year, nowaData.Month, nowaData.Day, nowaData.TimeOfDay, liczbaGodzin, id, dataDoZmiany.Year, dataDoZmiany.Month, dataDoZmiany.Day, dataDoZmiany.TimeOfDay);
            }
            MessageBox.Show("Nie znaleziono pracownika lub podanej daty nie ma w grafiku.");
            return "";

        }

        public string UsunZGrafiku(int id, DateTime dataDoUsuniecia)
        {

            Pracownik p = BazaDanych.ZwrocPracownika(id);
            if (p != null && p.grafik.CzyDataJestWGrafiku(dataDoUsuniecia))
            {
                p.grafik.UsuńZGrafiku(dataDoUsuniecia);
                return String.Format("DELETE FROM grafik WHERE (id = {0} AND dzien = '{1}{2}{3} {4}');", id, dataDoUsuniecia.Year, dataDoUsuniecia.Month, dataDoUsuniecia.Day, dataDoUsuniecia.TimeOfDay);
            }
            MessageBox.Show("Nie znaleziono pracownika lub podanej daty nie ma w grafiku.");
            return "";

        }

        public string UsunPracownika(int id)
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);
            if (p != null)
            {
                BazaDanych.magazyn.pracownicy.Remove(p);
                BazaDanych.WyczyscID(id);
                return String.Format("DELETE FROM pracownicy2 WHERE id={0}", id);
            }

            MessageBox.Show("Nie znaleziono pracownika o wskazanym ID");
            return "";
        }

        public List<Zlecenie> SprawdzListeZlecen()
        {
            throw new Exception();
        }


    }
}
