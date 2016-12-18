using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Pracownik : CzlonekFirmy
    {
        Grafik grafik;

        public Pracownik(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, Magazyn magazyn, BazaDanycch bd)
            : base(id, imie, nazwisko, pesel, telefon, dataUrodzenia, magazyn, bd) { }
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
