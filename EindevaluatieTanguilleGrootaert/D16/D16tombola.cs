using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16tombola
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            HashSet<int> tombolaNummers = new HashSet<int>();
            List<int> getallen = new List<int>();
            HashSet<int> winnendeNummers = new HashSet<int>();
            HashSet<int> gemisteWinnendeNummers = new HashSet<int>();

            string input;
            bool juist;

            for (int j = 0; j < 5; j++)
            {
                tombolaNummers.Add(rnd.Next(1000, 9999));
            }

            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine().Trim();
                juist = int.TryParse(input, out int getal);

                if (juist && getal > 999 && getal < 10000)
                {
                    getallen.Add(getal);
                }
                else
                {
                    Console.WriteLine("Ongeldige input");
                }
            } while (input != "");

            foreach (int nummer in tombolaNummers)
            {
                if (getallen.Contains(nummer))
                {
                    winnendeNummers.Add(nummer);
                }
                else
                {
                    gemisteWinnendeNummers.Add(nummer);
                }
            }
            Console.WriteLine("Uw winnende nummers zijn " + String.Join(" ", winnendeNummers));
            Console.WriteLine("De andere winnende nummers waren " + String.Join(" ", gemisteWinnendeNummers));
        }
    }
}
