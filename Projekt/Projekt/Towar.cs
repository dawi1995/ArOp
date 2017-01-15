using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public class Towar
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        //public int ilosc { get; set; }
        //public List<Lokalizacja> lokalizacje { get; set; }

        public Dictionary<Lokalizacja, int> lokalizacje { get; set; }

        public Towar() {
            lokalizacje = new Dictionary<Lokalizacja, int>();
        }

        public void UtwórzTowar(int id, string nazwa, Lokalizacja lokalizacja, int ilosc)
        {
            if (BazaDanych.magazyn.czyTowarIstnieje(id))
            {
                Komunikaty.WyświetlKomunikat("Towar o podanym ID już istnieje.");
                return;
            }

            this.id = id;
            this.nazwa = nazwa;
            lokalizacje = new Dictionary<Lokalizacja, int>();
            lokalizacje.Add(lokalizacja, ilosc);

            BazaDanych.WykonajWBazie(String.Format("INSERT INTO towary3 (id, nazwa) VALUES ({0}, '{1}');", id, nazwa));
            BazaDanych.WykonajWBazie(String.Format("INSERT INTO lokalizacje2 (idtowaru, sektor, rzad, polka, ilosc) VALUES ({0}, {1}, {2}, {3}, {4});", id, lokalizacja.sektor, lokalizacja.rzad, lokalizacja.polka, ilosc));
            
            Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
        }

        public void DodajTowar(int sektor, int rzad, int polka, int iloscDoDodania)
        {
            Lokalizacja lokalizacja = null;
            int ilosc = 0;

            foreach (var item in lokalizacje)
            {
                if (((Lokalizacja)item.Key).sektor == sektor && ((Lokalizacja)item.Key).rzad == rzad && ((Lokalizacja)item.Key).polka == polka)
                {
                    lokalizacja = (Lokalizacja)item.Key;
                    ilosc = item.Value;
                }
            }

            if (lokalizacja == null)
            {
                lokalizacje.Add(new Lokalizacja(sektor, rzad, polka), iloscDoDodania);
                BazaDanych.WykonajWBazie(String.Format("INSERT INTO lokalizacje2 (idtowaru, sektor, rzad, polka, ilosc) VALUES ({0}, {1}, {2}, {3}, {4});", id, sektor, rzad, polka, iloscDoDodania));
                Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
                return;
            }

            lokalizacje[lokalizacja] += iloscDoDodania;
            BazaDanych.WykonajWBazie(String.Format("UPDATE lokalizacje2 SET ilosc={0} WHERE (idtowaru={1}, sektor={2}, rzad={3}, polka={4});", ilosc+iloscDoDodania, sektor, rzad, polka));
            Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
        }

        public void UsuńTowar(int sektor, int rzad, int polka, int iloscDoUsuniecia)
        {
            Lokalizacja lokalizacja = null;
            int ilosc = 0;

            foreach (var item in lokalizacje)
            {
                if (((Lokalizacja)item.Key).sektor == sektor && ((Lokalizacja)item.Key).rzad == rzad && ((Lokalizacja)item.Key).polka == polka)
                {
                    lokalizacja = (Lokalizacja)item.Key;
                    ilosc = item.Value;
                }
            }

            if (lokalizacja == null)
            {
                Komunikaty.WyświetlKomunikat("Podanego towaru nie ma na wskazanej półce.");
                return;
            }

            if (ilosc < iloscDoUsuniecia)
            {
                Komunikaty.WyświetlKomunikat("Nie ma wystarczającej ilości towaru na wybranej półce.");
                return;
            }

            if (ilosc == iloscDoUsuniecia)
            {
                lokalizacje.Remove(lokalizacja);
                BazaDanych.WykonajWBazie(String.Format("DELETE FROM lokalizacje2 WHERE (idtowaru={0} AND sektor={1} AND rzad={2} AND polka={3});", id, sektor, rzad, polka));
                Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
                return;
            }

            lokalizacje[lokalizacja] -= ilosc;
            BazaDanych.WykonajWBazie(String.Format("UPDATE lokalizacje2 SET ilosc={4} WHERE (idtowaru={0} AND sektor={1} AND rzad={2} AND polka={3});", id, sektor, rzad, polka, ilosc-iloscDoUsuniecia));
            Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
        }
    }
}
