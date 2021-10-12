using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Hoeveel muntstukken van 2 euro heeft u ? ");
            string aantalMuntstukken2euroalstekst = Console.ReadLine();
            int aantalMuntstukken2euro = int.Parse(aantalMuntstukken2euroalstekst);

            Console.Write("Hoeveel muntstukken van 1 euro heeft u ? ");
            string aantalMuntstukken1euroalstekst = Console.ReadLine();
            int aantalMuntstukken1euro = int.Parse(aantalMuntstukken1euroalstekst);

            int totaalbedrag = (aantalMuntstukken2euro * 2) + aantalMuntstukken2euro;
            Console.Write("Het totale bedrag is " + totaalbedrag + " Euro.");


        }
    }
}



