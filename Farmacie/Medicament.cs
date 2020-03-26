using System;


namespace Farmacie
{
    class Medicament
    {
        int pret; // data membra privata
        public string nume_med;
        public string data_exp;
        public int cantitate;

        public Medicament()
        {
            nume_med = data_exp = string.Empty;
            pret = 0;
            cantitate = 0;
           
        }
        public Medicament(string _nume_med, string _data_exp, int _pret, int _cantitate)
        {
            nume_med = _nume_med;
            data_exp = _data_exp;
            pret = _pret;
            cantitate = _cantitate;
        }

        public void SetDate(string date)
        {
            string[] _date = date.Split(' ');
            nume_med = _date[0];
            data_exp = _date[1];
            cantitate = Convert.ToInt32(_date[2]);
            pret = Convert.ToInt32(_date[3]);
        }
        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda **SetDate**)";
            if ( nume_med != null)
            {
                sDate = string.Join(", ",nume_med, data_exp, cantitate, pret );
            }
            string s = string.Format(" {0} ", sDate);
            return s;
        }
    }
}
