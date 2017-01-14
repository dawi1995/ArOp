using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
   public class Grafik
    {
        public Dictionary<DateTime, int> grafik;

        public Grafik()
        {
            grafik = new Dictionary<DateTime, int>();
        }

        public void DodajDoGrafiku(int id, DateTime data, int czasPracy)
        {
            bool czyZnaleziono = false;

            foreach (var item in grafik)
            {
                if (item.Key.Date == data.Date)
                {
                    czyZnaleziono = true;
                }
            }

            if (czyZnaleziono)
            {
                Komunikaty.WyświetlKomunikat("W grafiku istnieje już taka data.");
                return;
            }

            grafik.Add(data, czasPracy);
            BazaDanych.WykonajWBazie(String.Format("INSERT INTO grafik (id, dzien, czas) values ({0}, '{1}', {2});", id, Narzędzia.PrzygotujDateDlaBazy(data), czasPracy));
            Komunikaty.WyświetlKomunikat("Operacja zakończoa powodzeniem.");
        }

        public void EdytujGrafik(int id, DateTime dataDoEdycji, DateTime nowaData, int nowyCzasPracy)
        {
            bool czyZnaleziono = false;
            DateTime doEdycji = new DateTime();

            foreach (var item in grafik)
            {
                if (item.Key.Date == dataDoEdycji.Date)
                {
                    czyZnaleziono = true;
                    doEdycji = item.Key;
                }
            }

            if(!czyZnaleziono)
            {
                Komunikaty.WyświetlKomunikat("Nie znaleziono wskazanej daty do edycji.");
                return;
            }

            grafik.Remove(doEdycji);
            grafik.Add(nowaData, nowyCzasPracy);
            BazaDanych.WykonajWBazie(String.Format("UPDATE grafik SET dzien='{0}', czas={1} WHERE (id={2} AND dzien='{3}');", Narzędzia.PrzygotujDateDlaBazy(nowaData), nowyCzasPracy, id, Narzędzia.PrzygotujDateDlaBazy(dataDoEdycji)));
            Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
        }

        public void UsuńZGrafiku(int id, DateTime dataDoUsunięcia)
        {
            bool czyZnaleziono = false;
            DateTime doEdycji = new DateTime();

            foreach (var item in grafik)
            {
                if (item.Key.Date == dataDoUsunięcia.Date)
                {
                    czyZnaleziono = true;
                    doEdycji = item.Key;
                }
            }

            if (!czyZnaleziono)
            {
                Komunikaty.WyświetlKomunikat("Nie znaleziono wskazanej daty do usunięcia.");
                return;
            }

            grafik.Remove(doEdycji);
            BazaDanych.WykonajWBazie(String.Format("DELETE FROM grafik WHERE (id = {0} AND dzien = '{1}');", id, Narzędzia.PrzygotujDateDlaBazy(dataDoUsunięcia)));
            MessageBox.Show("Operacja zakończona powodzeniem.");
        }

        public bool CzyDataJestWGrafiku(DateTime data)
        {
            return grafik.ContainsKey(data);
        }
    }
}
