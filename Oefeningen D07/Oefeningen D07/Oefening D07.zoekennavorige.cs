using System;

namespace ConsoleApp1
{
    class zoekennaarvorige
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            Console.Write("Geef de zoektekst: ");
            string zoekTekst = Console.ReadLine();

            int aantalGevonden = 0;

            string tekstKlein = tekst.ToLower();

            string zoektekstKlein = zoekTekst.ToLower();

            int resultaat = tekstKlein.IndexOf(zoektekstKlein);

            while (resultaat != -1)
            {
                aantalGevonden++;
                int resultaat2 = resultaat + 1;
                resultaat = tekstKlein.IndexOf(zoektekstKlein, resultaat + 1);

            }

            Console.WriteLine("De zoektekst komt " + aantalGevonden + " keer voor.");










        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_D07
{
    internal class Class1
    {
    }
}
