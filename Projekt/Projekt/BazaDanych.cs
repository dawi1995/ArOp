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
        SqlConnection connCO; // = new SqlConnection();
        SqlDataAdapter da; // = new SqlDataAdapter();
        DataSet ds; // = new DataSet();

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

        public Magazyn pobierzMagazyn()
        {
            Magazyn magazyn = new Magazyn();


            SkonfigurujPolaczenie();

            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand("SELECT * FROM towary", con))
                {
                    try
                    {
                        connCO.Open();
                        da.Fill(ds, "SRQs");
                        connCO.Close();
                    }
                    catch (Exception ex)
                    {
                        //TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }

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

                }
            }

            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand("SELECT * FROM pracownicy2", con))
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
                        //TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }

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

                }
            }

            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand("SELECT * FROM zlecenia", con))
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
                        //TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }

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

                }
            }


            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand("SELECT * FROM menadzerowie1", con))
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
                        //TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }

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

                }
            }

            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand("SELECT * FROM grafik", con))
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
                        //TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }

                    Pracownik pracownik;


                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            pracownik = magazyn.pracownicy.Find(Pracownik => Pracownik.id == (int)row.ItemArray[0]);

                            pracownik.grafik.grafik.Add((DateTime)row.ItemArray[1], (int)row.ItemArray[2]);
                        }

                    }

                }
            }

            using (SqlConnection con = new SqlConnection(connCO.ConnectionString))
            {
                using (da.SelectCommand = new SqlCommand("SELECT * FROM lokalizacje", con))
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
                        //TODO Error handeling
                        MessageBox.Show(ex.Message);
                    }

                    Towar towar;

                    foreach (DataTable tables in ds.Tables)
                    {
                        foreach (DataRow row in tables.Rows)
                        {
                            towar = magazyn.towary.Find(Towar => Towar.id == (int)row.ItemArray[0]);

                            towar.lokalizacje.Add(new Lokalizacja((int)row.ItemArray[1], (int)row.ItemArray[2], (int)row.ItemArray[3]));
                        }

                    }

                }
            }
            return magazyn;
        }
        public void AktualizujBaze()
        {

        }
        public Pracownik ZwrocPracownika(string login, string haslo)
        {
            throw new Exception();
        }
        public Menadzer ZwrocMenadzera(string login, string haslo)
        {
            throw new Exception();
        }
        public static BazaDanych UtworzBaze()
        {
            return new BazaDanych(@"DESKTOP-FE8VDHN\SQLEXPRESS", "hurtownia");
        }

    }
}
