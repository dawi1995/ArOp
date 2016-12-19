using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;
        public string pesel;
        public int telefon;
        public DateTime dataUrodzenia;
        string login;
        string haslo;

        public Osoba() { }
        public Osoba(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, string login, string haslo)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.telefon = telefon;
            this.dataUrodzenia = dataUrodzenia;
            this.login = login;
            this.haslo = haslo;
        }
    }
}
