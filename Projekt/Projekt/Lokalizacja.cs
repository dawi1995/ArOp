using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
   public class Lokalizacja
    {
        public int sektor { get; set; }
        public int rzad { get; set; }
        public int polka { get; set; }

        public Lokalizacja(int sektor, int rzad, int polka)
        {
            this.sektor = sektor;
            this.rzad = rzad;
            this.polka = polka;
        }

        public string Odczytaj()
        {
            return String.Format("sektor: {0}, rząd: {1}, półka: {2}", sektor, rzad, polka);
        }
    }
}
