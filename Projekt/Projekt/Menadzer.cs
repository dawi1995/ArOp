using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Menadzer : CzlonekFirmy
    {
        public Menadzer() { }
        public Menadzer(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, Magazyn magazyn, BazaDanych bd, string login, string haslo)
            : base(magazyn, bd, id, imie, nazwisko, pesel, telefon, dataUrodzenia, login, haslo) { }
        public void DodajPracownika(string imie, string nazwisko, string pesel, int telefon, DateTime rokUrodzenia, Magazyn magazyn, BazaDanych bd, string login, string haslo) //do uzupełnienia
        {

        }
        public void DodajDoGrafiku(int id, DateTime data, int liczbaGodzin)
        {

        }
        public void EdytujGrafik(int id, DateTime dataDoZmiany, DateTime nowaData, int liczbaGodzin)
        {

        }
        public void UsunZGrafiku(int id, DateTime dataDoUsuniecia)
        {

        }
        public void UsunPracownika(int id)
        {
        }
        public List<Zlecenie> SprawdzListeZlecen()
        {
            throw new Exception();
        }


    }
}
