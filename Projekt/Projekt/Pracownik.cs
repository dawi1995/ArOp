using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Pracownik : CzlonekFirmy
    {
        public Grafik grafik;


        public Pracownik() {
            grafik = new Grafik();

        }
        public Pracownik(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, Magazyn magazyn, BazaDanych bd, string login, string haslo)
            : base(magazyn, bd, id, imie, nazwisko,pesel, telefon, dataUrodzenia, login, haslo) {
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
        }
        public void DodajNowyTowar(string nazwa, int id, int sektor, int rzad, int polka)
        {
        }
    }
}
