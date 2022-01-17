
using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16vijfkleinstegetallen
    {
        static void Main(string[] args)
        {
            List<int> getallen = new List<int>();
            bool juist;
            int getal = 0;
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

            getallen.Sort();

            Console.Write("De 5 kleinste zijn ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(getallen[j] + " ");
            }
        }
    }
}
