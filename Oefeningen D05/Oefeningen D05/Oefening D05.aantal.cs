using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int teller = 0;
            int vorigGetal = 0;
            bool verderDoen = true;

            do
            {
                Console.Write("Geef een getal: ");
                string getalAlsTekst = Console.ReadLine();
                getal = int.Parse(getalAlsTekst);
                teller++;
                if (teller >= 2 && vorigGetal == getal)
                {
                    verderDoen = false;
                }
                else
                {
                    vorigGetal = getal;
                }
            } while (verderDoen);

            teller -= 2;
            Console.Write($"Aantal getallen ingevoerd: {teller}");
        }
    }
}
    
