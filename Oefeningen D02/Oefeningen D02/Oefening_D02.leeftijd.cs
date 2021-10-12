using System;

namespace Oefeningen_D02
{
    class D02leeftijd
    {
        static void Main(string[] args)
        {
            Console.Write("Geef naam: ");
            string naam1 = Console.ReadLine();

            Console.Write("Geef leeftijd: ");
            string leeftijd = Console.ReadLine();



            Console.WriteLine("Goeiedag " + naam1 + ", je bent dus " + leeftijd + " jaar oud!");
        }
    }
}
