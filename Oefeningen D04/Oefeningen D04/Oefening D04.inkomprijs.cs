using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef uw lengte in cm: ");
            int lengte = int.Parse(Console.ReadLine());


            Console.Write("Geef uw leeftijd: ");
            int leeftijd = int.Parse(Console.ReadLine());

            if (leeftijd > 20 && lengte <160)
            {
                Console.WriteLine("U betaalt slechts 5 euro inkom.");
            }
            else
            {
                Console.WriteLine("U betaalt 10 euro inkom.");
            }
        }
    }
}
    
