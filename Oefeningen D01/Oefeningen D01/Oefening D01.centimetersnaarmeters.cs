using System;

namespace Oefening_D01
{
    class D01centimetersnaarmeters
    {
        static void Main(string[] args)
        {
            int
            lengteInCm = 456;
            Console.WriteLine(lengteInCm);
            Console.WriteLine("cm = " );
            int volledigAantalMeters = lengteInCm / 100;
            int aantalResterendeCm = lengteInCm % 100;
            Console.WriteLine(volledigAantalMeters);
            Console.WriteLine("m en ");
            Console.WriteLine(aantalResterendeCm);
            Console.WriteLine("cm");
        }
    }
}
