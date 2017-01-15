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
            this.data = Convert.ToDateTime(String.Format("{0}-{1}-{2} {3}", now.Year, now.Month, now.Day, now.TimeOfDay.ToString("HH:mm:ss")));

            this.pracownik = pracownik;
            this.towar = towar;
            this.czyPrzyjeto = czyPrzyjeto;
            this.informacje = informacje;
            this.ilosc = ilosc;

            BazaDanych.WykonajWBazie(String.Format("INSERT INTO test (idpracownika, data, idtowaru, ilosc, przewoznik) VALUES ({0}, '{1}', {2}, {3},'{4}');", pracownik.id, data.Date.ToString("yyyyMMdd")+data.TimeOfDay, towar.id, ilosc, informacje));
        }
    }
}
