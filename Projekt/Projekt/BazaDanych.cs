using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projekt
{
    class BazaDanych
    {
        string adres;
        string login;
        string haslo;

        public BazaDanych(string adres, string login, string haslo)
        {
            this.adres = adres;
            this.login = login;
            this.haslo = haslo;
        }
        public void Polacz()
        {
        }
        public Magazyn pobierzMagazyn()
        {
            throw new Exception();
        }
        public void AktualizujMagazyn()
        {

        }
        public void Rozlacz()
        {
        }
        public bool Zaloguj(string login, string haslo)
        {
            throw new Exception();
        }
        public Pracownik ZwrocPracownika(string login, string haslo)
        {
            throw new Exception();
        }
        public Menadzer ZwrocMenadzera(string login, string haslo)
        {
            throw new Exception();
        }

    }
}
