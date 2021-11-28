using System;

namespace ConsoleApp1
{
    class cirkel
    {
        static void Main(string[] args)
        {

            Console.Write("Geef de straal van een cirkel in cm: ");
            double straal = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            double omtrek = 2 * pi * straal;
            Console.WriteLine($"De omtrek van de cirk bedraagt {omtrek,3:f3} cm.");

            double oppervlakte = straal * straal * pi;
            Console.WriteLine($"De oppervlakte van de cirkel bedraagt {oppervlakte,3:f3} cm².");
        }
    }
}
