using System;

namespace D09
{
    class D09langstewoord
    {
        static void Main(string[] args)
        {
            char[] seperators = { ' ', ',', '.', '!', '?' };
            int woordenTeller = 0;
            string langstewoord= "";

            Console.Write("Schrijf hier uw tekst: ");
            string input = Console.ReadLine();
            string[] woorden = input.Split(seperators);

            for (int i = 0; i < woorden.Length; i++)           
            {
                if (woorden[i].Length > langstewoord.Length)
                {
                    langstewoord = woorden[i];
                }
              woordenTeller++;
            }
          
            Console.WriteLine("aantal woorden: " + woordenTeller);
            Console.WriteLine("langste woord: " + langstewoord);

        }
    }
}

