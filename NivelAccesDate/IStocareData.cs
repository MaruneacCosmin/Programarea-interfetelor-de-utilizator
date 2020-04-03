using LibrarieClase;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMed(Medicament x);
        Medicament[] GetMed(out int nrMed);
        void ModifMed(string x, string y, int i);

        //void ReplaceTextInFile(string searchTerm, string replaceTerm);
    }
}