using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef uw jaarinkomen: ");
            int inkomen = int.Parse(Console.ReadLine());


            Console.Write("Geef uw aantal kinderen: ");
            int kinderen = int.Parse(Console.ReadLine());

            if (inkomen > 20000 || kinderen < 3)
            {
                Console.WriteLine("U heeft geen recht op de toelage.");
            }
            else
            {
                Console.WriteLine($"U heeft recht op {inkomen * 0.03}EUR toeslag.");
            }
        }
    }
}
    
