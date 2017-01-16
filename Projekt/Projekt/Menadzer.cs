using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public class Menadzer : CzlonekFirmy
    {
        public Menadzer() { }

        public Menadzer(int id, string imie, string nazwisko, string pesel, int telefon, DateTime dataUrodzenia, Magazyn magazyn, string login, string haslo)
            : base(id, imie, nazwisko, pesel, telefon, dataUrodzenia, login, haslo) { }

        public void DodajPracownika(int id, string imie, string nazwisko, string pesel, int telefon, DateTime rokUrodzenia) //do uzupełnienia
        {
            if (BazaDanych.ZwrocPracownika(id) != null)
            {
                MessageBox.Show("Pracownik o takim ID już istnieje.");
                return;
            }

            string login = imie.ToLower();
            string haslo = nazwisko.ToLower();
            Pracownik p = new Pracownik(id, imie, nazwisko, pesel, telefon, rokUrodzenia, login, haslo);
            BazaDanych.magazyn.pracownicy.Add(p);

            BazaDanych.WykonajWBazie(String.Format("INSERT INTO pracownicy2 (id, imie, nazwisko, pesel, telefon, dataurodzenia, login, haslo) VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}');", id, imie, nazwisko, pesel, telefon, Narzędzia.PrzygotujDateDlaBazy(rokUrodzenia), login, haslo ));
            Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
        }

        public void DodajDoGrafiku(int id, DateTime data, int liczbaGodzin) //+ do sprawdzenia
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);

            if (p == null)
            {
                Komunikaty.WyświetlKomunikat("W bazie nie ma pracownika o podanym ID.");
                return;
            }

            p.grafik.DodajDoGrafiku(id, data, liczbaGodzin);
        }

        public void EdytujGrafik(int id, DateTime dataDoZmiany, DateTime nowaData, int liczbaGodzin) // + do sprawdzenia
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);

            if (p == null)
            {
                Komunikaty.WyświetlKomunikat("W bazie nie ma pracownika o podanym ID.");
                return;
            }

            p.grafik.EdytujGrafik(id, dataDoZmiany, nowaData, liczbaGodzin);


        }

        public void UsunZGrafiku(int id, DateTime dataDoUsuniecia)
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);

            if (p == null)
            {
                Komunikaty.WyświetlKomunikat("W bazie nie ma pracownika o podanym ID.");
                return;
            }

            p.grafik.UsuńZGrafiku(id, dataDoUsuniecia);
        }

        public void UsunPracownika(int id)
        {
            Pracownik p = BazaDanych.ZwrocPracownika(id);
            if (p == null)
            {
                MessageBox.Show("Nie znaleziono pracownika o wskazanym ID");
                return;
            }

            DialogResult odpowiedź = MessageBox.Show("Czy na pewno chcesz usunąć pracownika - " + p.imie + " " + p.nazwisko + "?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(odpowiedź == DialogResult.No)
            {
                return;
            }

            BazaDanych.magazyn.pracownicy.Remove(p);
            BazaDanych.WyczyscID(id);
            BazaDanych.WykonajWBazie(String.Format("DELETE FROM pracownicy2 WHERE id={0}", id));
            Komunikaty.WyświetlKomunikat("Operacja zakończona powodzeniem.");
        }

        public List<Zlecenie> SprawdzListeZlecen()
        {
            throw new Exception();
        }


    }
}
