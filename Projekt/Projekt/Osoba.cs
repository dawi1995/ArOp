using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Osoba
    {
        int id;
        string imie;
        string nazwisko;
        string pesel;
        int telefon;
        DateTime dataUrodzenia;
        public Osoba(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.telefon = telefon;
            this.dataUrodzenia = dataUrodzenia;
        }
    }
}
