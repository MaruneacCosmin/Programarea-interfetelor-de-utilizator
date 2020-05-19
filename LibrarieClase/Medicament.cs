using System;
using System.Collections.Generic;

namespace LibrarieClase
{
    [Serializable]
    public class Medicament
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';
        private const char SEPARATOR_SECUNDAR_FISIER = ',';
        public static int NID { get; set; } = 0;
        public int ID { get; set; }
        public int Pret {get; set; }
        public string Nume_med { get; set; }
        public int Cantitate { get; set; }

        int Reducere;

        public DateTime Data_exp { get; set; }
        public DateTime DataActualizare { get; set; }

        public List<string> Medicamente { get; set; }

        public int Doza { get; set; }

        
        public TipAdministrare TipAdm { get; set; }

        public string TipMedAsString
        {
            get
            {
                string x = string.Empty;

                foreach (string disciplina in Medicamente)
                {
                    if (x != string.Empty)
                    {
                        x += SEPARATOR_SECUNDAR_FISIER;
                    }
                    x += disciplina;
                }

                return x;
            }
        }

        public void setReducere(int x)
        {
                Reducere = x;
        }

        public int getReducere()
        {
            return Reducere;
        }

        //constructor implicit
        public Medicament()
        {
            Nume_med = string.Empty;
            Data_exp = DateTime.Now;
            Pret = 0;
            Cantitate = 0;
            ID = ++NID;
        }

        //constructor cu parametrii
        public Medicament(string _Nume_med, string _Pret, string _Cantitate)
        {
            Nume_med = _Nume_med;
           
            Pret = Convert.ToInt32(_Pret);
            Cantitate = Convert.ToInt32 (_Cantitate);
            ID = ++NID;
        }

        
        //metoda de setare a unor date introduse intr-o propozitie de la tastatura
        public Medicament(string date)
        {
           /// s.ID, s.Nume_med, s.Data_exp, s.Pret, s.Cantitate, s.TipAdm, Tip = string.Join(",", s.Medicamente), s.Doza, s.DataActualizare
            var dateFisier = date.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            ID = Convert.ToInt32(dateFisier[(int)CampuriMedicament.ID]);
            Nume_med = dateFisier[(int)CampuriMedicament.NUME];
            Pret= Convert.ToInt32(dateFisier[(int)CampuriMedicament.Pret]);
            Cantitate = Convert.ToInt32(dateFisier[(int)CampuriMedicament.CANTITATE]);
            TipAdm = (TipAdministrare)Enum.Parse(typeof(TipAdministrare), dateFisier[(int)CampuriMedicament.TIP_ADMINISTRARE]);
            Medicamente = new List<string>();
            //adauga mai multe elemente in lista de discipline
            Medicamente.AddRange(dateFisier[(int)CampuriMedicament.MEDICAMENTE].Split(SEPARATOR_SECUNDAR_FISIER));
            Doza = Int32.Parse(dateFisier[(int)CampuriMedicament.DOZA]);
        }

        //metoda de convertire la sir pentru afisarea datelor
        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda **SetDate**)";
            if ( Nume_med != null)
            {
                sDate = string.Join(" ", ID, Nume_med, Pret, Cantitate, TipAdm, TipMedAsString, Doza);
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
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{9}{0}{10}", SEPARATOR_PRINCIPAL_FISIER, ID, Nume_med, Pret, Cantitate, TipAdm, TipMedAsString, Doza, Data_exp, DataActualizare, Reducere);
            return s;
        }

        public override string ToString()
        {
            return ConversieLaSir_Fisier();
        }
    }
}
