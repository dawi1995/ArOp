using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
   public class Grafik
    {
        public Dictionary<DateTime, int> grafik;

        public Grafik()
        {
            grafik = new Dictionary<DateTime, int>();
        }

        public void DodajDoGrafiku(DateTime data, int czasPracy)
        {
            grafik.Add(data, czasPracy);
            MessageBox.Show("Pomyślnie zaktualizowano grafik");
        }

        public void EdytujGrafik(DateTime dataDoEdycji, DateTime nowaData, int nowyCzasPracy)
        {
            for (int i = 0; i < grafik.Count; i++)
            {
                if (grafik.ElementAt(i).Key.CompareTo(dataDoEdycji) == 0)
                {
                    grafik.Remove(grafik.ElementAt(i).Key);
                    grafik.Add(nowaData, nowyCzasPracy);
                    MessageBox.Show("Pomyślnie zedytowno grafik");
                    return;
                }
            }
            MessageBox.Show("Nie odnaleziono szukanej daty.");
        }

        public void UsuńZGrafiku(DateTime dataDoUsunięcia)
        {

            for (int i = 0; i < grafik.Count; i++)
            {
                if (grafik.ElementAt(i).Key.CompareTo(dataDoUsunięcia) == 0)
                {
                    grafik.Remove(grafik.ElementAt(i).Key);
                    MessageBox.Show("Pomyślnie usunięto wpis z grafiku.");
                    return;
                }
            }
            MessageBox.Show("Nie odnaleziono szukanej daty.");
        }

        public bool CzyDataJestWGrafiku(DateTime data)
        {
            return grafik.ContainsKey(data);
        }
    }
}
