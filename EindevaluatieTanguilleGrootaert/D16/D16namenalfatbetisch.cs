using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16namenalfatbetisch
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string>();
            string naam = string.Empty;
            int i = 1;
            
            do
            {
                Console.Write($"Geef naam {i}: ");
                naam = Console.ReadLine().Trim();
                namen.Add(naam);
                i++;
            } while (naam != "");

            namen.Sort();

            foreach (string n in namen)
            {
                Console.WriteLine(n);
            }
        }
    }
}
