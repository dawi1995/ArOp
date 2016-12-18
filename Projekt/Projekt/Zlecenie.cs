using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Zlecenie
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
        public int PobierzPracownika()
        {
            throw new Exception();
        }
        public DateTime PobierzDate()
        {
            throw new Exception();
        }
        public int PobierzIdTowaru()
        {
            throw new Exception();
        }
        public string PobierzPrzewoźnika()
        {
            throw new Exception();
        }
        public string PobierzRodzajOperacji()
        {
            throw new Exception();
        }
    }
}
