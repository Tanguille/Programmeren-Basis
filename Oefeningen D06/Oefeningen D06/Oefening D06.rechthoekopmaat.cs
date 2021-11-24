using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gelukt;

            int breedte = 0;
            do
            {
                Console.Write("Geef de breedte : ");
                string breedteAlsTekst = Console.ReadLine();
                gelukt = int.TryParse(breedteAlsTekst, out breedte);
            } while (!gelukt || breedte < 1);

            int hoogte = 0;
            do
            {
                Console.Write("Geef de hoogte: ");
                string hoogteAlsTekst = Console.ReadLine();
                gelukt = int.TryParse(hoogteAlsTekst, out hoogte);
            } while (!gelukt || hoogte < 1);

            string horizontaal = "";
            for (int i = 0; i < breedte; i++)
            {
                horizontaal += "*";
            }
            for (int i = 0; i < hoogte; i++)
            {
                Console.WriteLine(horizontaal);
            }
        }
    }
}

    


