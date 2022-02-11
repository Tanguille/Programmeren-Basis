using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16uniekegetallentonen
    {
        static void Main(string[] args)
        {
            HashSet<int> getallen = new HashSet<int>();
            bool juist;
            int getal;
            int i = 0;
            do
            {
                Console.Write("Geef een getal: ");
                juist = int.TryParse(Console.ReadLine(), out getal);
                getallen.Add(getal);

                if (!juist)
                {
                    Console.WriteLine("Ongeldige input");
                }
                else
                {
                    i++;
                }
            } while (i < 10);

            Console.Write(getallen.Count + " unieke getallen: " + String.Join(",", getallen));
        }
    }
}

