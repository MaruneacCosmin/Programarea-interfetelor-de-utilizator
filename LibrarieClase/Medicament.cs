using System;


namespace LibrarieClase
{
    public class Medicament
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';

        public static int NID { get; set; } = 0;
        public int ID { get; set; }
        int pret; // data membra privata
        public string Nume_med { get; set; }
        public string Data_exp { get; set; }
        public int Cantitate { get; set; }

        public TipMedicament TipMed { get; set; }

        //constructor implicit
        public Medicament()
        {
            Nume_med = Data_exp = string.Empty;
            pret = 0;
            Cantitate = 0;
            ID = ++NID;
        }

        //constructor cu parametrii
        public Medicament(string _Nume_med, string _Data_exp, int _pret, int _Cantitate)
        {
            Nume_med = _Nume_med;
            Data_exp = _Data_exp;
            pret = _pret;
            Cantitate = _Cantitate;
            ID = ++NID;
        }

        
        //metoda de setare a unor date introduse intr-o propozitie de la tastatura
        public Medicament(string date)
        {
            
            var _date = date.Split(SEPARATOR_PRINCIPAL_FISIER);
            ID = Convert.ToInt32(_date[0]);
            Console.WriteLine("ID ESTE {0}",ID);
            Nume_med = _date[1];
            Data_exp = _date[2];
            Cantitate = Convert.ToInt32(_date[3]);
            pret = Convert.ToInt32(_date[4]);
            TipMed = (TipMedicament)Enum.Parse(typeof(TipMedicament), _date[5]);
            NID = ID;
        }

        //metoda de convertire la sir pentru afisarea datelor
        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda **SetDate**)";
            if ( Nume_med != null)
            {
                sDate = string.Join(", ", ID,Nume_med, Data_exp, Cantitate, pret, TipMed );
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
            
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", SEPARATOR_PRINCIPAL_FISIER, ID, (Nume_med ?? " NECUNOSCUT "), (Data_exp ?? " NECUNOSCUT "), Cantitate, pret, TipMed);
            return s;
        }
    }
}
