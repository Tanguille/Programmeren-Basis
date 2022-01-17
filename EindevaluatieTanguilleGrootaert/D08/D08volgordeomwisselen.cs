using System;

namespace D08
{
    class D08volgordeomwisselen
    {
        static void Main(string[] args)
        {
            //nog maken
            int aantalNamen = 4;
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