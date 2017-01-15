using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Pulpit_DodajTowarcs : Form
    {
        Pracownik pracownik;
        public Pulpit_DodajTowarcs(Pracownik p)
        {
            InitializeComponent();
            pracownik = p; 
        }

        private void button_DodajNowyTowar_Click(object sender, EventArgs e)
        {
            bool czyWaliduje = true;

            if (!Projekt.Validate.CheckIfString(textBox_nazwatowaru))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfPositiveInt(textBox_idtowaru))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfLocalization(textBox_sektor))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfLocalization(textBox_rzad))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfLocalization(textBox_polka))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfPositiveInt(textBox_ilosc))
                czyWaliduje = false;

            if (!Projekt.Validate.CheckIfString(textBox_info))
                czyWaliduje = false;

            if (czyWaliduje == true)
            {
                pracownik.DodajNowyTowar(textBox_nazwatowaru.Text, Convert.ToInt32(textBox_idtowaru.Text), Convert.ToInt32(textBox_sektor.Text), Convert.ToInt32(textBox_rzad.Text), Convert.ToInt32(textBox_polka.Text), Convert.ToInt32(textBox_ilosc.Text), textBox_info.Text);
                return;
            }
            Komunikaty.NieprawidlowaWalidacja();
            
        }
    }
}
