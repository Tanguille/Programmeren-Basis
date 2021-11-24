using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gelukt;

            int hoogte = 0;
            do
            {
                Console.Write("Geef de hoogte: ");
                string hoogteAlsTekst = Console.ReadLine();
                gelukt = int.TryParse(hoogteAlsTekst, out hoogte);
            } while (!gelukt || hoogte < 1);

            
            for (int i = 1; i <= hoogte; i++)
            {
                for (int k = 0; k < i ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }         
        }
    }
}

    


