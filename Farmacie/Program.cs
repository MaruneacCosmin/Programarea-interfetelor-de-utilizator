using System;
using LibrarieClase;
using NivelAccesDate;

namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            IStocareData adminMed = StocareFactory.GetAdministratorStocare();
            Medicament[] medicamente;
            string opt;
            int nrMed;
            medicamente = adminMed.GetMed(out nrMed);
            Medicament.NID = nrMed;
            bool ok = true;
            while (ok == true)
            {
                Console.Clear();
                Console.WriteLine("A: Adaugare medicament ");
                Console.WriteLine("E: Editare medicament");
                Console.WriteLine("D: Stergere medicament");
                Console.WriteLine("O: Afisare lista medicamente");
                Console.WriteLine("S: Cautare medicament");
                Console.WriteLine("C: Comparare");
                Console.WriteLine("X: Iesire");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "A":
                        Console.Clear();
                        Medicament t = CitireTast();
                        medicamente[nrMed] = t;
                        nrMed++;
                        adminMed.AddMed(t);
                        Console.WriteLine("--------  PRESS ANY KEY --------");
                        Console.ReadKey();
                        break;
                    case "E":
                        Console.Clear();
                        int z = 0;
                        string mod;
                        Console.WriteLine("Introduceti medicamentul pe care doriti sa-l modificati: ");
                        string demodificat = Console.ReadLine();
                        Console.WriteLine("Ce anume doriti sa modificati?");
                        string modificare = Console.ReadLine();
                        if (String.Compare(modificare, "pret") == 0)
                            Console.WriteLine("Nu puteti modifica pretul!");
                        else
                        { 
                            for (int i = 0; i < nrMed; i++)
                            {
                                if ((medicamente[i].Nume_med.CompareTo(demodificat)) == 0)
                                {
                                    z = 1;
                                    if (String.Compare(modificare, "nume") == 0)
                                    {
                                        Console.WriteLine("Medicament gasit! Introduceti noua denumire:");
                                        mod=Console.ReadLine();
                                        medicamente[i].Nume_med = mod;
                                        adminMed.ModifMed(medicamente[i].Nume_med, mod,medicamente[i].ID);
                                    }
                                    if (String.Compare(modificare, "data") == 0)
                                    {
                                        Console.WriteLine("Medicament gasit! Introduceti noua data de expirare:");
                                        mod = Console.ReadLine();
                                        medicamente[i].Data_exp = mod;
                                        adminMed.ModifMed(medicamente[i].Data_exp, mod, medicamente[i].ID);
                                    }
                                    if (String.Compare(modificare, "Cantitate") == 0)
                                    {
                                        Console.WriteLine("Medicament gasit! Introduceti noua Cantitate:");
                                        mod = Console.ReadLine();
                                        medicamente[i].Cantitate = Convert.ToInt32(mod);
                                        string conv = medicamente[i].Cantitate.ToString();
                                        adminMed.ModifMed(conv, mod, medicamente[i].ID);
                                    }
                                }
                                if (z == 1)
                                    i = nrMed;
                            }

                            if (z==0)
                               Console.WriteLine(" Medicamentul nu exista!");
                        }
                        Console.WriteLine("--------  PRESS ANY KEY --------");
                        Console.ReadKey();
                        break;
                    case "D":
                        Console.Clear();
                        Console.WriteLine("--------  METODA ESTE IN CURS DE IMPLEMENTARE --------");
                        Console.WriteLine("\t--------  PRESS ANY KEY --------");
                        Console.ReadKey();
                        break;
                    case "O":
                        Console.Clear();
                        for (int i=0;i<nrMed;i++)
                        {
                            Console.WriteLine(medicamente[i].ConversieLaSir());
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("--------  PRESS ANY KEY --------");
                        Console.ReadKey();
                        break;
                    case "S":
                        Console.Clear();
                        int k = 0;
                        Info();
                        string decautat = Console.ReadLine();
                        for (int i = 0; i < nrMed; i++)
                            if ((medicamente[i].Nume_med.CompareTo(decautat)) == 0)
                                k = 1;
                        if (k == 1)
                            Info1();
                        else
                            Info2();

                        Console.WriteLine("--------  PRESS ANY KEY --------");
                        Console.ReadKey();
                        break;

                    case "C":
                        Console.Clear();
                        if (medicamente[0].Compara(medicamente[1]) == 1)
                            Console.WriteLine("OK");
                        Console.WriteLine("--------  PRESS ANY KEY --------");
                        Console.ReadKey();
                        break;

                    case "X":
                        Console.Clear();
                        ok = false;
                        break;
                }

            }
            Console.WriteLine("\n \n \n \n \n \n \n \n \t \t \t \t \t --------  Sfarit program --------\n \n ");
            Console.WriteLine("\t \t \t \t \t --------  PRESS ANY KEY --------");
            Console.ReadKey();
        }
        public static void Info()
        {
            Console.WriteLine("Introduceti numele medicamentului pe care doriti sa-l cautati: ");

        }
        public static void Info1()
        {
            Console.WriteLine("Medicamentul a fost gasit! ");

        }
        public static void Info2()
        {
            Console.WriteLine("Medicamentul nu exista! ");

        }
        public static Medicament CitireTast()
        {
            Console.WriteLine("Introduceti numele medicamentului: ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti data expirarii: ");
            string data = Console.ReadLine();

            Console.WriteLine("Introduceti pretul:");
            int pret = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti Cantitatea:");
            int Cantitate = Convert.ToInt32(Console.ReadLine());

            Medicament t = new Medicament(nume, data, pret, Cantitate);

            Console.WriteLine("Introduceti tipul medicamentului:");
            Console.WriteLine("1. Antibiotic \n" +
                              "2. Vaccin \n" +
                              "3. Vitamine \n" +
                              "4. Antiinflamator \n");

            t.TipMed = (TipMedicament)Int32.Parse(Console.ReadLine());

            return t;
        }
    }
}
