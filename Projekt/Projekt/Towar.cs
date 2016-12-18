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
        public int id { get; set; }
        public string nazwa { get; set; }
        public int ilosc { get; set; }
        public List<Lokalizacja> lokalizacje { get; set; }

        public Towar() {
            lokalizacje = new List<Lokalizacja>();
        }

        public Towar(int id, string nazwa, int ilosc, Lokalizacja lokalizacja)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.ilosc = ilosc;
            lokalizacje = new List<Lokalizacja>();
            lokalizacje.Add(lokalizacja);
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
