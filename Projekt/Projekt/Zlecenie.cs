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
        public string informacje;
        public int ilosc;

        public Zlecenie() { }
        public void UtwórzZlecenie(Pracownik pracownik, Towar towar, int ilosc, bool czyPrzyjeto, string informacje)
        {
            DateTime now = DateTime.Now;
            string dataNow = now.ToString("yyyyMMdd ") + now.TimeOfDay;
            dataNow = dataNow.Substring(0, 16);

            this.pracownik = pracownik;
            this.towar = towar;
            this.data = now;
            this.czyPrzyjeto = czyPrzyjeto;
            this.informacje = informacje;
            this.ilosc = ilosc;

            BazaDanych.WykonajWBazie(String.Format("INSERT INTO zlecenia2 (idpracownika, data, idtowaru, ilosc, czyPrzyjeto, przewoznik) VALUES ({0}, '{1}', {2}, {3}, '{4}', '{5}');", pracownik.id, dataNow, towar.id, ilosc, czyPrzyjeto, informacje));
            //BazaDanych.WykonajWBazie(String.Format("INSERT INTO test (idpracownika, data, idtowaru, ilosc, przewoznik) VALUES ({0}, '{1}', {2}, {3}, '{4}');", pracownik.id, dataNow, towar.id, ilosc, informacje));
        }
    }
}
