using System;


namespace LibrarieClase
{
    public class Medicament
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';

        // public static int NID { get; set; } = 0;
        // public int ID { get; set; }
        int pret; // data membra privata
        public string Nume_med { get; set; }
        public string Data_exp { get; set; }
        public int Cantitate { get; set; }

        public enum TipMedicament
        {
            Antibiotic = 1,
            Vaccin = 2,
            Vitamine = 3,
            Antiinflamator = 4
        };

        //constructor implicit
        public Medicament()
        {
            Nume_med = Data_exp = string.Empty;
            pret = 0;
            Cantitate = 0;
           // ID = ++NID;
        }

        //constructor cu parametrii
        public Medicament(string _Nume_med, string _Data_exp, int _pret, int _Cantitate)
        {
            Nume_med = _Nume_med;
            Data_exp = _Data_exp;
            pret = _pret;
            Cantitate = _Cantitate;
           // ID = ++NID;
        }

        
        //metoda de setare a unor date introduse intr-o propozitie de la tastatura
        public Medicament(string date)
        {
            var _date = date.Split(SEPARATOR_PRINCIPAL_FISIER);
            Nume_med = _date[0];
            Data_exp = _date[1];
            Cantitate = Convert.ToInt32(_date[2]);
            pret = Convert.ToInt32(_date[3]);
        }

        //metoda de convertire la sir pentru afisarea datelor
        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda **SetDate**)";
            if ( Nume_med != null)
            {
                sDate = string.Join(", ",Nume_med, Data_exp, Cantitate, pret );
            }
            string s = string.Format(" {0} ", sDate);
            return s;
        }
      

        public int Compara(Medicament med)
        {
            return this.Data_exp.CompareTo(med.Data_exp);
        }

        public string ConversieLaSir_Fisier()
        {
            string sMed = string.Empty;
            if (Nume_med != null)
            {
                sMed = string.Join(SEPARATOR_AFISARE, pret);
            }
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}", SEPARATOR_PRINCIPAL_FISIER, (Nume_med ?? " NECUNOSCUT "), (Data_exp ?? " NECUNOSCUT "), Cantitate, sMed);

            return s;
        }
    }
}
