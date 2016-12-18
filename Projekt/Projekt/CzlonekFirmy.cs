﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class CzlonekFirmy : Osoba
    {
        Magazyn magazyn;
        BazaDanych bd;
        public CzlonekFirmy(Magazyn magazyn, BazaDanych bd, int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia)
            : base(id, imie, nazwisko, pesel, telefon, dataUrodzenia)
        {
            this.magazyn = magazyn;
            this.bd = bd;
        }
    }

}