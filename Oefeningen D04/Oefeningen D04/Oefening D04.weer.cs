using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
            bool hetRegent = (regen == "ja");



            if (zon == "ja" && regen == "ja")
            {
                Console.WriteLine("Regenboog.");
            }
            else if (zon == "nee" && regen == "nee")
            {
                Console.WriteLine("Slecht weer.");
            }
            else if (zon == "ja" && regen == "nee")
            {
                Console.WriteLine("Mooi weer.");
            }
            else if (zon == "nee" && regen == "nee")
            {
                Console.WriteLine("Saaie dag");
            }
        }
    }
}
