using System;
using Farmacie;

namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicament t = new Medicament("Parasinus", "24.04.2019", 24, 10);
            string opt;
            bool ok = true;
            while (ok == true)
            {
                
                Console.WriteLine("A: Adaugare medicament "); // Implemnetat doar pentru cerinta laboratorului.
                Console.WriteLine("E: Editare medicament");
                Console.WriteLine("D: Stergere medicament");
                Console.WriteLine("O: Afisare lista medicamente"); // urmeaza a fi implementata ca lista. Pentru moment am respectat doar cerinta laboratorului.
                Console.WriteLine("S: Cautare medicamente");
                Console.WriteLine("X: Iesire");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Adaugati informatiile despre medicament");
                        t.SetDate(Console.ReadLine());
                        break;
                    case "E":
                        {
                            break;
                        }
                       
                    case "D":
                        break;
                    case "O":
                        Console.WriteLine(t.ConversieLaSir());
                        break;
                    case "S":
                        
                        break;
                    case "X":
                        ok = false;
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
