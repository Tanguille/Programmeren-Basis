using System;

namespace Oefeningen_D02
{
    class D02leeftijdvolgendjaar
    {
        static void Main(string[] args)
        {
            Console.Write("Geef naam: ");
            string naam1 = Console.ReadLine();

            Console.Write("Geef leeftijd: ");
            string leeftijd = Console.ReadLine();

            int leeftijd2 = int.Parse(leeftijd) + 1;

            Console.WriteLine($"Oei Oei {naam1}, volgend jaar ben je al {leeftijd2} jaar oud!");
        }
    }
}
