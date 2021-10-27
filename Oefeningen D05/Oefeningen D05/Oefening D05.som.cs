using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int getal = 0;
                         
            do
            {
                Console.Write("Geef een getal: ");
                string getalAlsTekst = Console.ReadLine();
                getal = int.Parse(getalAlsTekst);
                som += getal;
            } while (getal != -1);

            som -= getal;

        Console.Write($" De som is {som}.");

        }
    }
}
    
