using LibrarieClase;
using System;
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

        void UpdateMedd(Medicament Actualizat, int index);

        List<Medicament> GetMedPret();

        List<Medicament> GetMedData(DateTime x, DateTime y);
    }
}