using LibrarieClase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelAccesDate
{

    public class AdministrareMedicamente_FisierBinar : IStocareData
    {
        private const int ID_PRIMUL_MEDICAMENT = 1;
        private const int INCREMENT = 1;
        string NumeFisier { get; set; }
        public AdministrareMedicamente_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        
        public void AddMed(Medicament s)
        {
            s.ID = GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializare unui obiect
                    b.Serialize(sBinFile, s);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public void UpdateMedd(Medicament Actualizat, int index)
        {
            List<Medicament> medicamente = GetMedicamente();
            
            try
            {

                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Medicament med in medicamente)
                    {

                        if (med.ID != index)
                        {
                            swFisierText.WriteLine(med.ConversieLaSir_Fisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(Actualizat.ConversieLaSir_Fisier());
                        }
                    }
                    
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public List<Medicament> GetMedicamente()
        {
            List<Medicament> Medicamenti = new List<Medicament>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Medicamenti.Add((Medicament)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return Medicamenti;
        }
        public Medicament GetMedByIndex(int index)
        {
            Medicament s = null;
            List<Medicament> Medicamente = new List<Medicament>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                int contor = 0;
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        s = (Medicament)b.Deserialize(sBinFile);
                        //Observati conversia!!!
                        Medicamente.Add((Medicament)b.Deserialize(sBinFile));
                        if (contor == index)
                        {
                            break;
                        }
                        contor++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return s;
        }

        public Medicament GetMed(string nume)
        {
            throw new Exception("Optiunea GetMedicament nu este implementata");
        }

        public bool UpdateMed(Medicament m)
        {
            bool ok = false;
            List<Medicament> Medicamente = GetMedicamente();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Truncate, FileAccess.Write))
                {
                    foreach (var med in Medicamente)
                    {
                        //serializare unui obiect
                        if (med.ID == m.ID)
                        {
                            b.Serialize(sBinFile, m);
                        }
                        else
                            b.Serialize(sBinFile, med);
                    }
                    ok = true;

                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return ok;
        }

        private int GetId()
        {
            int IdMedicament = ID_PRIMUL_MEDICAMENT;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Medicament s = (Medicament)b.Deserialize(sBinFile);
                        IdMedicament = s.ID + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdMedicament;
        }
        public List<Medicament> GetMedPret()
        {
            List<Medicament> Medicamente = GetMedicamente();
            List<Medicament> sub100 = new List<Medicament>();
            foreach (Medicament s in Medicamente)
            {
                if (s.Cantitate >= 10)
                    sub100.Add(s);
            }
            return sub100;
        }
        public List<Medicament> GetMedData(DateTime x, DateTime y)
        {
            List<Medicament> Medicamente = GetMedicamente();
            List<Medicament> md = new List<Medicament>();
            foreach (Medicament s in Medicamente)
            {
                if ((s.Data_exp >= x) && (s.Data_exp <= y))
                    md.Add(s);
            }
            return md;
        }
    }
}

