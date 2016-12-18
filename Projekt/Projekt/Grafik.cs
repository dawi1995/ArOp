using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Grafik
    {
        public Dictionary<DateTime, int> grafik;

        public Grafik()
        {
            grafik = new Dictionary<DateTime, int>();
        }

        public void DodajDoGrafiku(DateTime data, int czasPracy)
        {
            grafik.Add(data, czasPracy);
        }

        public void EdytujGrafik(DateTime dataDoEdycji, DateTime nowaData, int nowyCzasPracy)
        {
            for (int i = 0; i < grafik.Count; i++)
            {
                if (grafik.ElementAt(i).Key.CompareTo(dataDoEdycji) == 0)
                {
                    grafik.ElementAt(i);

                }
            }
        }
    }
}
