using LibrarieClase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace NivelAccesDate
{
    
    public class AdministrareMedicamente_FisierText : IStocareData
    {
        private const int ID_PRIMUL_MEDICAMENT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }


        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
  
        }

        public void ReplaceTextInFile(string searchTerm, string replaceTerm)
        {
            var content = string.Empty; 
            using (StreamReader reader = new StreamReader(NumeFisier))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }

            content = Regex.Replace(content, searchTerm, replaceTerm);

            using (StreamWriter writer = new StreamWriter(NumeFisier))
            {
                writer.Write(content);
                writer.Close();
            }
        }

        public bool UpdateMed(Medicament medActualizat)
        {
            List<Medicament> medicamente = GetMedicamente();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Medicament med in medicamente)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (med.ID != medActualizat.ID)
                        {
                            swFisierText.WriteLine(med.ConversieLaSir_Fisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(medActualizat.ConversieLaSir_Fisier());
                        }
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;
        }


        public void AddMed(Medicament x)    
        {
            x.ID = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(x.ConversieLaSir_Fisier());
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

      

        public Medicament GetMed(string nume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament Medicament = new Medicament(line);
                        if (Medicament.Nume_med.Equals(nume))
                            return Medicament;
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
            return null;
        }

        public List<Medicament> GetMedicamente()
        {
            List<Medicament> medicamente = new List<Medicament>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament s = new Medicament(line);
                        medicamente.Add(s);
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

            return medicamente;
        }



        public Medicament GetMedByIndex(int index)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    int contor = 0;
                    //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament Medicament = new Medicament(line);
                        if (contor == index)
                            return Medicament;
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
            return null;
        }

        public bool UpdateMedicament(Medicament MedicamentActualizat)
        {
            List<Medicament> Medicamente = GetMedicamente();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Medicament stud in Medicamente)
                    {
                        //informatiile despre Medicamentul actualizat vor fi preluate din parametrul "MedicamentActualizat"
                        if (stud.ID != MedicamentActualizat.ID)
                        {
                            swFisierText.WriteLine(stud.ConversieLaSir_Fisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(MedicamentActualizat.ConversieLaSir_Fisier());
                        }
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdMedicament = ID_PRIMUL_MEDICAMENT;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament s = new Medicament(line);
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
            List<Medicament> sub100= new List<Medicament>();
            foreach (Medicament s in Medicamente)
            {
                if (s.Cantitate >= 10)
                    sub100.Add(s);
            }
            return sub100;
        }
    }
}
