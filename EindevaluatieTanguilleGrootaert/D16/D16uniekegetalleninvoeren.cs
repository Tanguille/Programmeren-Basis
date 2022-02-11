using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16uniekegetalleninvoeren
    {
        static void Main(string[] args)
        {
            List<int> getallen = new List<int>();
            bool juist;            
            int i = 0;

            do
            {
                Console.Write("Geef een getal: ");
                juist = int.TryParse(Console.ReadLine(), out int getal);

                if (!juist)
                {
                    Console.WriteLine("Ongeldige input");
                }
                else if (getallen.Contains(getal))
                {
                    Console.WriteLine("Das een dubbel");
                }
                else
                {
                    i++;
                    getallen.Add(getal);
                }
            } while (i < 10);

            Console.Write("unieke getallen: " + String.Join(",", getallen));
        }
    }
}
