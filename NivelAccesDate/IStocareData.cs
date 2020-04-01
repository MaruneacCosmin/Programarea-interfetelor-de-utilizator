using LibrarieClase;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMed(Medicament x);
        Medicament[] GetMed(out int nrMed);
    }
}