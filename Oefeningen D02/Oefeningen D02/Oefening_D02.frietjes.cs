using System;

namespace Oefeningen_D02 {
    class D02frietjes {
        static void Main(string[] args) {
            Console.Write("Geef naam: ");
            string naam1 = Console.ReadLine();

            Console.Write("Geef nog een naam: ");
            string naam2 = Console.ReadLine();

            Console.Write("Geef een gerecht: ");
            string gerecht = Console.ReadLine();


            Console.WriteLine($"{naam1} en {naam2} eten graag {gerecht}.");
        }
    }
}
