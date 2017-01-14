using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projekt
{
    
    public class BazaDanych
    {
        string adres;
        string nazwa;
        //string haslo;
        public SqlConnection connCO; // = new SqlConnection();
        public SqlDataAdapter da; // = new SqlDataAdapter();
        public DataSet ds; // = new DataSet();

        public BazaDanych(string adres, string nazwa)
        {
            this.adres = adres;
            this.nazwa = nazwa;
            //this.haslo = haslo;
        }
        public void SkonfigurujPolaczenie()
        {
            connCO = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            connCO.ConnectionString = @"Data Source=" + adres + ";Initial Catalog=" + nazwa + ";Integrated Security=SSPI";

        }

        
        public void WykonajWBazie(string komendaSql) 
        {
            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand(komendaSql, con))
                {
                    try
                    {
                        connCO.Open();
                        ds = new DataSet();
                        da.Fill(ds, "SRQs");
                        connCO.Close();
                    }
                    catch (Exception ex)
                    {
                        //@TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public Magazyn pobierzMagazyn()
        {
            Magazyn magazyn = new Magazyn();


            SkonfigurujPolaczenie();
            WykonajWBazie("SELECT * FROM towary");
            
                    Towar towar;

                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            towar = new Towar();
                            towar.id = (int)row.ItemArray[0];
                            towar.nazwa = (string)row.ItemArray[1];
                            towar.ilosc = (int)row.ItemArray[2];

                            magazyn.towary.Add(towar);
                        }

                    }
            WykonajWBazie("SELECT * FROM pracownicy2");
            
                    Pracownik pracownik;

                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            pracownik = new Pracownik();
                            pracownik.id = (int)row.ItemArray[0];
                            pracownik.imie = (string)row.ItemArray[1];
                            pracownik.nazwisko = (string)row.ItemArray[2];
                            pracownik.pesel = (string)row.ItemArray[3];
                            pracownik.telefon = (int)row.ItemArray[4];
                            pracownik.dataUrodzenia = (DateTime)row.ItemArray[5];
                            pracownik.login = (string)row.ItemArray[6];
                            pracownik.haslo = (string)row.ItemArray[7];
                            magazyn.pracownicy.Add(pracownik);
                        }

                    }
            WykonajWBazie("SELECT * FROM zlecenia");
            

                    Zlecenie zlecenie;

                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            zlecenie = new Zlecenie();
                            zlecenie.pracownik = magazyn.pracownicy.Find(Pracownik => Pracownik.id == Convert.ToInt32(row.ItemArray[0]));
                            zlecenie.data = (DateTime)row.ItemArray[1];
                            zlecenie.towar = magazyn.towary.Find(Towar => Towar.id == (int)row.ItemArray[2]);
                            zlecenie.czyPrzyjeto = (bool)row.ItemArray[3]; //nie wiadomo czy zrzutuje
                            zlecenie.przewoznik = (string)row.ItemArray[4];
                            magazyn.zlecenia.Add(zlecenie);
                        }

                    }

            WykonajWBazie("SELECT * FROM menadzerowie1");
            
                    Menadzer menadzer;

                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            menadzer = new Menadzer();
                            menadzer.id = (int)row.ItemArray[0];
                            menadzer.imie = (string)row.ItemArray[1];
                            menadzer.nazwisko = (string)row.ItemArray[2];
                            menadzer.pesel = (string)row.ItemArray[3];
                            menadzer.telefon = (int)row.ItemArray[4];
                            menadzer.dataUrodzenia = (DateTime)row.ItemArray[5];
                            menadzer.login = (string)row.ItemArray[6];
                            menadzer.haslo = (string)row.ItemArray[7];
                            magazyn.menadzerowie.Add(menadzer);
                        }

                    }
            WykonajWBazie("SELECT * FROM grafik");
            
            
                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            pracownik = magazyn.pracownicy.Find(Pracownik => Pracownik.id == (int)row.ItemArray[0]);

                            pracownik.grafik.grafik.Add((DateTime)row.ItemArray[1], (int)row.ItemArray[2]);
                        }

                    }
            WykonajWBazie("SELECT * FROM lokalizacje");

                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            towar = magazyn.towary.Find(Towar => Towar.id == (int)row.ItemArray[0]);

                            towar.lokalizacje.Add(new Lokalizacja((int)row.ItemArray[1], (int)row.ItemArray[2], (int)row.ItemArray[3]));
                        }

                    }
            return magazyn;
        }
        /*
        public void AktualizujBaze()
        {
            WykonajWBazie("insert into menadzerowie1 values (2,'Dawid', 'Brzęczek',7894613,2222222,12-12-2016,'Jacek','Mariański')");
        }
        */
        public Pracownik ZwrocPracownika(int id) //bez sensu zwracac po loginie i hasle, lepiej po ID
        {
            Magazyn magazyn = pobierzMagazyn();
            Pracownik pracownik = null;
            for (int i = 0; i < magazyn.pracownicy.Count; i++)
            {
                if (magazyn.pracownicy[i].id==id)
                {
                    pracownik = magazyn.pracownicy[i];
                }
                else
                {
                    MessageBox.Show("Nie ma pracownika o podanym id");
                }
            }
            return pracownik;

        }
        public Menadzer ZwrocMenadzera(int id) //tu tez bez sensu
        {
            Magazyn magazyn = pobierzMagazyn();
            Menadzer menadzer = null;
            for (int i = 0; i < magazyn.menadzerowie.Count; i++)
            {
                if (magazyn.menadzerowie[i].id == id)
                {
                    menadzer = magazyn.menadzerowie[i];
                }
                else
                {
                    MessageBox.Show("Nie ma menadzera o podanym id");
                }
            }
            return menadzer;
        }
        public static BazaDanych UtworzBaze()
        {
            return new BazaDanych(@"DESKTOP-FE8VDHN\SQLEXPRESS", "hurtownia");
        }

    }
}
