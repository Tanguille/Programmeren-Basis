using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int aantal = 0;
            int getal = 0;
                                     
            do
            {
                Console.Write("Geef een getal: ");
                string getalAlsTekst = Console.ReadLine();
                getal = int.Parse(getalAlsTekst);
                som += getal;
                aantal++;

            } while (getal != -1);

            som -= getal;
            aantal--;
            
            double gemiddelde = som / aantal;
            Console.Write($"Het gemiddelde is {gemiddelde}.");

        }
    }
}
    
