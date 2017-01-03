using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Menadzer : CzlonekFirmy
    {
        public Menadzer() { }
        public Menadzer(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, Magazyn magazyn, BazaDanych bd, string login, string haslo)
            : base(magazyn, bd, id, imie, nazwisko, pesel, telefon, dataUrodzenia, login, haslo) { }
        public void DodajPracownika(int id,string imie, string nazwisko, string pesel, int telefon, DateTime rokUrodzenia, Magazyn magazyn, BazaDanych bd, string login, string haslo) //do uzupełnienia
        {
            Pracownik p = new Pracownik(id, imie, nazwisko, pesel, telefon, rokUrodzenia, magazyn, bd, login, haslo);
            magazyn.pracownicy.Add(p);
            bd.AktualizujBaze();
        }

        public void DodajDoGrafiku(int id, DateTime data, int liczbaGodzin) //+ do sprawdzenia
        {

            BazaDanych bd = BazaDanych.UtworzBaze();
            bd.SkonfigurujPolaczenie();
            Pracownik p = bd.ZwrocPracownika(id);
            p.grafik.DodajDoGrafiku(data, liczbaGodzin);
        }
        public void EdytujGrafik(int id, DateTime dataDoZmiany, DateTime nowaData, int liczbaGodzin) // + do sprawdzenia
        {
            BazaDanych bd = BazaDanych.UtworzBaze();
            bd.SkonfigurujPolaczenie();
            Pracownik p = bd.ZwrocPracownika(id);
            p.grafik.EdytujGrafik(dataDoZmiany,nowaData,liczbaGodzin);
        }
        public void UsunZGrafiku(int id, DateTime dataDoUsuniecia)
        {
            BazaDanych bd = BazaDanych.UtworzBaze();
            bd.SkonfigurujPolaczenie();
            Pracownik p = bd.ZwrocPracownika(id);
            p.grafik.UsuńZGrafiku(dataDoUsuniecia);
        }
        public void UsunPracownika(int id)
        {
            BazaDanych bd = BazaDanych.UtworzBaze();
            bd.SkonfigurujPolaczenie();
            Magazyn magazyn = bd.pobierzMagazyn();
            Pracownik p = bd.ZwrocPracownika(id);
            magazyn.pracownicy.Remove(p);
        }
        public List<Zlecenie> SprawdzListeZlecen()
        {
            throw new Exception();
        }


    }
}
