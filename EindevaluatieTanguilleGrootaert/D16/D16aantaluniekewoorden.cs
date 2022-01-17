using System;
using System.Collections.Generic;
using System.Linq;

namespace D16
{
    internal class D16aantaluniekewoorden
    {
        static void Main(string[] args)
        {
            char[] seperators = { ' ', ',', '.', '?', '!' };

            Console.Write("Geef een tekst: ");
            string woord = Console.ReadLine();
            string[] woordenArray = woord.ToLower().Split(seperators);
            HashSet<string> tekst = new HashSet<string>(woordenArray);
         

            Console.WriteLine("Aantal unieke woorden: " + tekst.Count);

            List<string> gesorteerdeTekst = new List<string> (tekst.ToList());
            gesorteerdeTekst.Sort();
            Console.Write("Alfabetische volgorde: ");
            foreach (string w in gesorteerdeTekst) 
            {
                Console.Write(w + " ");
            }
        }
    }
}
