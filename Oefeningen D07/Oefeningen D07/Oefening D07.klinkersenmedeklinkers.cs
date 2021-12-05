using System;

namespace ConsoleApp1
{
    class klinkersenmedeklinkers
    {
        static void Main(string[] args)
        {            
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            string klinkers = "aeiou";
            int aantalKlinkers = 0;

            string medeklinkers = "bcdfghjklmnpqrstvwxyz";
            int aantalMedeklinkers = 0;

            foreach (char c in tekst)
            {
               char cKlein = Char.ToLower(c);

                if (klinkers.Contains(cKlein))
                {
                    aantalKlinkers  ++;
                }
                else if (medeklinkers.Contains(cKlein))
                {
                    aantalMedeklinkers ++;
                }
               
            }
            Console.WriteLine($"{aantalKlinkers} klinker(s) en {aantalMedeklinkers} medeklinkers.");
        }
    }
}
