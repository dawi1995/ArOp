using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
   public class Pracownik : CzlonekFirmy
    {
        public Grafik grafik;


        public Pracownik() {
            grafik = new Grafik();

        }
        public Pracownik(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, string login, string haslo)
            : base(id, imie, nazwisko,pesel, telefon, dataUrodzenia, login, haslo) {
            grafik = new Grafik();
        }
        
        public void UsunTowar(int id, int sektor, int rzad, int polka, int iloscDoUsuniecia, string informacja)
        {
            Towar doUsuniecia = BazaDanych.magazyn.towary.Find(Towar => Towar.id == id);

            if (doUsuniecia == null)
            {
                Komunikaty.WyświetlKomunikat("W magazynie nie ma takiego towaru.");
                return;
            }

            Zlecenie nowe = new Zlecenie();
            doUsuniecia.UsuńTowar(sektor, rzad, polka, iloscDoUsuniecia);
            nowe.UtwórzZlecenie(this, doUsuniecia, iloscDoUsuniecia, false, informacja);

            BazaDanych.magazyn.zlecenia.Add(nowe);
        }

        public void DodajIstniejacyTowar(int id, int sektor, int rzad, int polka, int iloscDoDodania, string informacja)
        {
            Towar doDodania = BazaDanych.magazyn.towary.Find(Towar => Towar.id == id);

            if (doDodania == null)
            {
                Komunikaty.WyświetlKomunikat("W magazynie nie ma towaru o podanym ID.");
                return; 
            }

                
            DialogResult odpowiedź = MessageBox.Show("Czy na pewno chcesz dodać towar - " + doDodania.nazwa + "?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(odpowiedź == DialogResult.No)
            {
                return;
            }

            Zlecenie nowe = new Zlecenie();

            nowe.UtwórzZlecenie(this, doDodania, iloscDoDodania, true, informacja);
            doDodania.DodajTowar(sektor, rzad, polka, iloscDoDodania);

            BazaDanych.magazyn.zlecenia.Add(nowe);
        }

        public void DodajNowyTowar(string nazwa, int id, int sektor, int rzad, int polka, int ilosc, string informacja)
        {

            Towar doDodania = BazaDanych.magazyn.towary.Find(Towar => Towar.id == id);

            if (doDodania != null)
            {
                Komunikaty.WyświetlKomunikat("W magazynie istnieje już towar o podanym ID.");
                return;
            }

            Zlecenie nowe = new Zlecenie();
            doDodania = new Towar();
            
            doDodania.UtwórzTowar(id, nazwa, new Lokalizacja(sektor, rzad, polka), ilosc);
            nowe.UtwórzZlecenie(this, doDodania, ilosc, true, informacja);

            BazaDanych.magazyn.towary.Add(doDodania);
            BazaDanych.magazyn.zlecenia.Add(nowe);
        }
    }
}
