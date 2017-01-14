using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public class Magazyn
    {
        public List<Towar> towary { get; set; } 
        public List<Pracownik> pracownicy { get; set; }
        public List<Menadzer> menadzerowie { get; set; }
        public List<Zlecenie> zlecenia { get; set; }
        public BazaDanych db { get; set; }

        public Magazyn()
        {
            towary = new List<Towar>();
            pracownicy = new List<Pracownik>();
            zlecenia = new List<Zlecenie>();
            menadzerowie = new List<Menadzer>();
            
        }

        public void DodajZlecenie(Pracownik pracownik, DateTime dataWykonaniaZlecenia, Towar towar, bool czyPrzyjeto, string przewoznik)
        {
            zlecenia.Add(new Projekt.Zlecenie(pracownik, dataWykonaniaZlecenia, towar, czyPrzyjeto, przewoznik));
            MessageBox.Show("Pomyślnie dodano zlecenie.");
        }

        public bool czyTowarIstnieje(int id)
        {
            Towar towar = towary.Find(Towar => Towar.id == id);

            if (towar != null)
                return true;
            else
                return false; 
        }
    }
}
