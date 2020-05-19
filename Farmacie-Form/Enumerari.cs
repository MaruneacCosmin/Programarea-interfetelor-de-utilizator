using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie_Form
{
    [Flags]
    public enum CodEroare
    {
        CORECT = 0,
        NUME_INCORECT = 1,
        CANTITATE_INCORECTA = 2,
        Pret_INCORECT = 4,
        ADMINISTRARE_INCORECTA = 8,
        TIP_INCORECT = 16
    }
}
