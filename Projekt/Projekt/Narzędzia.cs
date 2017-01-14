using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Narzędzia
    {
        public static string PrzygotujDateDlaBazy(DateTime d)
        {
            return d.Date.ToString("yyyyMMdd HH:mm");
        }
    }
}
