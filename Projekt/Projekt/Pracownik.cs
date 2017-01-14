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
        
        public void UsunTowar(int id, int sektor, int rzad, int polka, int iloscDoUsuniecia)
        {
            Towar doUsuniecia = BazaDanych.magazyn.towary.Find(Towar => Towar.id == id);

            if (doUsuniecia == null)
            {
                Komunikaty.WyświetlKomunikat("W magazynie nie ma takiego towaru.");
                return;
            }

            doUsuniecia.UsuńTowar(sektor, rzad, polka, iloscDoUsuniecia);
        }

        public void DodajIstniejacyTowar(int id, int sektor, int rzad, int polka, int iloscDoDodania)
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

            doDodania.DodajTowar(sektor, rzad, polka, iloscDoDodania);
        }

        public void DodajNowyTowar(string nazwa, int id, int sektor, int rzad, int polka, int ilosc)
        {

            Towar doDodania = BazaDanych.magazyn.towary.Find(Towar => Towar.id == id);

            if (doDodania != null)
            {
                Komunikaty.WyświetlKomunikat("W magazynie istnieje już towar o podanym ID.");
                return;
            }

            doDodania = new Towar();
            doDodania.UtwórzTowar(id, nazwa, new Lokalizacja(sektor, rzad, polka), ilosc);
            BazaDanych.magazyn.towary.Add(doDodania);
        }
    }
}
