using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public enum TipMedicament
    {
        Antibiotic = 1,
        Vaccin = 2,
        Vitamine = 3,
        Antiinflamator = 4
    };

    [Flags]
    public enum CombinatiiMedicament
    {
        Antibiotic = 1,
        Vaccin = 2,
        Vitamine = 3,
        Antiinflamator = 4
    }

}
