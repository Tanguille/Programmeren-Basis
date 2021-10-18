using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double conversieFeet = 30.48;
            const double conversieInches = 2.54;

            Console.Write("Geef het aantal feet : ");
            string aantalFeetAlsTekst = Console.ReadLine();
            double aantalFeet = double.Parse(aantalFeetAlsTekst);

            Console.Write("Geef het aantal inches : ");
            string aantalInchesAlsTekst = Console.ReadLine();
            double aantalInches = double.Parse(aantalInchesAlsTekst);

            double aantalFeetInCm = aantalFeet * conversieFeet;
            double aantalInchesInCm = aantalInches * conversieInches;

            double totaalInCm = aantalFeetInCm + aantalInchesInCm;

            Console.WriteLine($"Dat is {totaalInCm} cm.");
        }
    }
}
