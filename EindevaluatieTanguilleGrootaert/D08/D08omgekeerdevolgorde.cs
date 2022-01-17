using System;

namespace D08
{
    class D08omgekeerdevolgorde
    {
        static void Main(string[] args)
        {
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

            //Ik heb lang zitten zoeken op deze oefening en ben via google Array.Reverse tegengekomen dus ik heb het zo aangepakt.
            Array.Reverse(namen);

            for (int i = 0; i < aantalNamen; i++)
            {
                Console.WriteLine(namen[i]);
            }
        }
    }
}