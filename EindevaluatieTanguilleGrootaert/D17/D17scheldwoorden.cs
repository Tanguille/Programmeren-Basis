using System;
using System.Collections.Generic;

namespace D17
{
    internal class D17scheldwoorden
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> scheldwoordenBoek = new Dictionary<string, string> { {"barslet", "Slet die in bar opereert."},{"kantoorpik","Fantasieloze saaie man die op zijn bureau werkt."}, { "boerenheikneuter", "Een onbeschaafd, onwetend persoon."}, {"charlatan", "Leenwoord uit het Frans charlatan, in de betekenis van ‘kwakzalver’ voor het eerst aangetroffen in 1658." }, { "lummel", "Leenwoord uit het Duits, in de betekenis van ‘onhandige vent’ voor het eerst aangetroffen in 1700" } };
            while (true)
            {
                Console.Write("Geef een scheldwoord: ");
                string scheldwoord = Console.ReadLine();

                if (scheldwoordenBoek.ContainsKey(scheldwoord))
                {                    
                    Console.WriteLine(scheldwoordenBoek[scheldwoord]);
                }
                else
                {
                    Console.WriteLine("Geen gekend scheldwoord.");
                }
            }
        }
    }
}
