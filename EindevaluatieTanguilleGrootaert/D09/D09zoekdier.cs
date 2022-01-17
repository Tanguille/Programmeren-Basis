using System;

namespace D09
{
    class D09zoekdier
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };
            bool gevonden = false;

            Console.Write("Geef een dier: ");
            string dier = Console.ReadLine();
            string dierKlein = dier.ToLower();

            for (int i = 0; i < dier.Length; i++)
            {
                if (dierKlein == boerderijDieren[i])
                {
                    Console.WriteLine($"{dier} is een boerderijdier.");
                    gevonden = true;
                    break;
                }                            
            }
            if (!gevonden)            
            {
                Console.WriteLine($"{dier} is geen boerderijdier.");                
            }
        }
    }
}
