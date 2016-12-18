using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Towar
    {
        int id;
        string nazwa;
        int ilosc;
        List<Lokalizacja> lokalizacje;

        public Towar(int id, string nazwa, int ilosc, Lokalizacja lokalizacja)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.ilosc = ilosc;
            this.lokalizacje.Add(lokalizacja);
        }

        public void Usuńlokalizacje(int sektor, int rzad, int polka)
        {
            for (int i = 0; i < lokalizacje.Count; i++)
            {
                if (lokalizacje[i].sektor == sektor && lokalizacje[i].sektor == rzad && lokalizacje[i].polka == polka)
                {
                    lokalizacje.Remove(lokalizacje[i]);
                    MessageBox.Show("Pomyślnie usunięto wskazaną lokalizację");
                    return;
                }
            }
            MessageBox.Show("Nie odnaleziono podanej lokalizacji towaru.");
        }
    }
}
