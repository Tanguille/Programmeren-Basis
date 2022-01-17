using System;

namespace D08
{
    class D08omgekeerdevolgordehoeveel
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel namen wenst u in te geven?: ");
            int aantalNamen = int.Parse(Console.ReadLine());

            string[] namen = new string[aantalNamen];
                       
            for (int i = 0; i < aantalNamen; i++)
            {
                Console.Write("Geef een naam: ");
                {
                    string naam = Console.ReadLine();
                    namen[i] = naam;
                }
            }

            for (int j = aantalNamen; j > 0; j--)
            {
                Console.WriteLine(namen[j - 1]);
            }

        }
    }
}