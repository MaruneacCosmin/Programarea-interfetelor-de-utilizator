using System;


namespace Farmacie
{
    class Medicament
    {
        int[] pret; // data membra privata
        public string nume_med;
        public string data_exp;

        public Medicament()
        {
            nume_med = data_exp = string.Empty;

        }
        public Medicament(string _nume_med, string _data_exp, int[] _pret)
        {
            nume_med = _nume_med;
            data_exp = _data_exp;
            _pret.CopyTo(pret, 0);
        }

    }
}
