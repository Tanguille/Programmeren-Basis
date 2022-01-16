using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16zoektermenvooraan
    {
        static void Main(string[] args)
        {
            List<string> zoekhistoriek = new List<string> { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };

            do
            {
                string zoekhistoriekZichtbaar = String.Join(":", zoekhistoriek);
                Console.WriteLine(zoekhistoriekZichtbaar);

                Console.Write("Nieuwe zoekterm: ");
                zoekhistoriek.Insert(0, Console.ReadLine());

                zoekhistoriek.Remove(zoekhistoriek[zoekhistoriek.Count - 1]);

            } while (true);
        }
    }
}
