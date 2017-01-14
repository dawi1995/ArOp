using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class CzlonekFirmy : Osoba
    {
        public CzlonekFirmy() { }
        public CzlonekFirmy(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, string login, string haslo)
            : base(id, imie, nazwisko, pesel, telefon, dataUrodzenia, login, haslo) { }
    }

}
