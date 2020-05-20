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
    
    public enum TipAdministrare
    {
        Tip_Inexistent=0,
        Orala =1,
        Parenteral=2
    };

    public enum CampuriMedicament
    {
        /// s.ID, s.Nume_med, s.Data_exp, s.Pret, s.Cantitate, s.TipAdm, Tip = string.Join(",", s.Medicamente), s.Doza, s.DataActualizare
        ID = 0,
        NUME = 1,
        Pret = 2,
        CANTITATE=3,
        TIP_ADMINISTRARE = 4,
        MEDICAMENTE = 5,
        DOZA = 6 ,
        DATA_EXP=7,
        DATA_ACT=8
    };
}
