using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Geef een kommagetal: ");
            string eersteKommagetalalstekst = Console.ReadLine();
            decimal eersteKommagetal = decimal.Parse(eersteKommagetalalstekst);

            Console.Write("Geef nog een kommagetal: ");
            string tweeddeKommagetalalstekst = Console.ReadLine();
            decimal tweeddeKommagetal = decimal.Parse(tweeddeKommagetalalstekst);

            Console.Write("Geef nog een kommagetal: ");
            string derdeKommagetalalstekst = Console.ReadLine();
            decimal derdeKommagetal = decimal.Parse(derdeKommagetalalstekst);

            Console.Write((eersteKommagetal + tweeddeKommagetal + derdeKommagetal)/3);
        }
    }
}

