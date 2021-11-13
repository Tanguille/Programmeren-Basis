using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string getalOfStop;
            bool invoerOk;
            int som = 0;

            do
            {
                getalOfStop = Console.ReadLine();
                invoerOk = int.TryParse(getalOfStop, out int getal);
                if (invoerOk)
                {
                    som += getal;
                    Console.WriteLine("+");
                }
                else if (getalOfStop.ToUpper().Trim() != "STOP")
                {
                    Console.WriteLine("Gelieve een geldig getal in te voeren (STOP om te stoppen)");
                }
                
            } while (getalOfStop.ToUpper().Trim() != "STOP");

            Console.Write($"=\n{som}");
        }                       
        }
    }


