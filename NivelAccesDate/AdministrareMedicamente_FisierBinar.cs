using LibrarieClase;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{

    public class AdministrareMedicamente_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMedicamente_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMed(Medicament s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public Medicament[] GetMed(out int nrStudenti)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
