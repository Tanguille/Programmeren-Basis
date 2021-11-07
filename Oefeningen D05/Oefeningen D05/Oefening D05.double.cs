using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een (double) getal in?: ");
            double getalAlsTekst;
            bool ValidInput = double.TryParse(Console.ReadLine(), out getalAlsTekst);

            while (ValidInput)
            {
                Console.WriteLine("Bedankt voor het getal.");
                Console.Write("Gelieve nog een (double) getal in te voeren: ");
                ValidInput = double.TryParse(Console.ReadLine(), out getalAlsTekst);
            }

            Console.WriteLine("Einde (wegens geen double getal).");
        }
    }
}

