﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Komunikaty
    {
        public static void WyświetlKomunikat(string treść)
        {
            MessageBox.Show(treść);
        }
        public static void NieprawidlowaWalidacja()
        {
            MessageBox.Show("Zły format wpisanych danych", "Bład walidacji!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
