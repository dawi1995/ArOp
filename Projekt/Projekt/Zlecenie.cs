using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Zlecenie
    {
        public Pracownik pracownik;
        public DateTime data;
        public Towar towar;
        public bool czyPrzyjeto;
        public string przewoznik;

        public Zlecenie() { }
        public Zlecenie(Pracownik pracownik, DateTime data, Towar towar, bool czyPrzyjeto, string przewoznik)
        {
            this.pracownik = pracownik;
            this.data = data;
            this.towar = towar;
            this.czyPrzyjeto = czyPrzyjeto;
            this.przewoznik = przewoznik;
        }
    }
}
