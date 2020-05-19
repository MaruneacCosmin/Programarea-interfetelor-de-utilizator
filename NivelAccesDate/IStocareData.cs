using LibrarieClase;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        List<Medicament> GetMedicamente();
        Medicament GetMedByIndex(int index);

        void AddMed(Medicament x);
        Medicament GetMed(string nume);

        bool UpdateMed(Medicament s);

        List<Medicament> GetMedPret();

        //void ReplaceTextInFile(string searchTerm, string replaceTerm);
    }
}