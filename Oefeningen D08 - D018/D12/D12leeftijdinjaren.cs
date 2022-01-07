using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12leeftijdinjaren
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");
            DateTime dateTime;
            bool gelukt;

            do
            {
                Console.Write("Geef een datum (dd/mm/jjjj): ");
                gelukt = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", nlBe, System.Globalization.DateTimeStyles.None, out dateTime);
                
                if (!gelukt)
                {
                    Console.WriteLine("Ongeldige Datum.");
                }
            } while (!gelukt);

            //Gevonden na opzoeken.
            int vandaag = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int verjaardag = int.Parse(dateTime.ToString("yyyyMMdd"));
            int leeftijdInJaar = (vandaag - verjaardag) / 10000;

            Console.WriteLine($"Vandaag is het {DateTime.Today.ToString().Substring(0,9)}, dus u bent nu {leeftijdInJaar} jaar oud.");
        }
    }
}
