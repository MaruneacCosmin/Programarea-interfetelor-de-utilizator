using LibrarieClase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace NivelAccesDate
{
    
    public class AdministrareMedicamente_FisierText : IStocareData
    {
        private const int PAS_ALOCARE = 10;
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

        public void ModifMed(string x, string y, int id)
        {
            try
            {
                // Deschide stream pentru fișierul sursă
                using (var sourceFile = File.OpenText(NumeFisier))
                {
                    // Creaează o cale temporară unde putem modifica datele
                    string tempFile = Path.Combine(Path.GetDirectoryName(NumeFisier), "Temporary.txt"); 
                    // Deschide un stream pentru fișierul temporar
                    using (var tempFileStream = new StreamWriter(tempFile))
                    {
                        string line;
                        // Citește liniile 
                        while ((line = sourceFile.ReadLine()) != null)
                        {
                            string[] date = line.Split(' ');
                            Console.WriteLine("{0}", date[1]);
                            string z= Console.ReadLine();
                            if(date [0]== Convert.ToString(id))
                                 line = line.Replace(x, y); // Face înlocuirea
                            // Scrie linia nouă în fișierul temporar
                            tempFileStream.WriteLine(line);
                        }
                    }
                }
                // Înlocuiește fișierul original cu cel temporar
                File.Replace("Medicamente.txt", "Temporary.txt", null);
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


        public void AddMed(Medicament x)
        {
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

        public Medicament[] GetMed(out int nrMed)
        {
            Medicament[] medicamente = new Medicament[PAS_ALOCARE];

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nrMed = 0;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        medicamente[nrMed++] = new Medicament(line);
                        if (nrMed == PAS_ALOCARE)
                        {
                            Array.Resize(ref medicamente, nrMed + PAS_ALOCARE);
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
            return medicamente;
        }
    }
}
