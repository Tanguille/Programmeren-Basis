using System;

namespace D09
{
    class D09zoekhistoriek
    {
        static void Main(string[] args)
        {
            string[] zoekhistoriek = { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };
            
            do
            {
                string zoekhistoriekZichtbaar = String.Join(":", zoekhistoriek);
                Console.WriteLine(zoekhistoriekZichtbaar);

                Console.Write("Nieuwe zoekterm: ");
                string zoekterm = Console.ReadLine();

                
                for (int i = 0; i > zoekhistoriek.Length - 1; i++)
                {
                    zoekhistoriek[i] = zoekhistoriek[i+1];
                }
                zoekhistoriek[zoekhistoriek.Length-1] = zoekterm;

            } while (true);
        }
    }
}
