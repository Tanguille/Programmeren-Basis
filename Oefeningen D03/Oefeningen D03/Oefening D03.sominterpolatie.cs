using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("geef een getal :");
            string getal1 = Console.ReadLine();

            Console.Write("geef u tweede getal :");
            string getal2 = Console.ReadLine();
            int uitkomst = int.Parse(getal1) + int.Parse(getal2);

            Console.Write($"{getal1} plus {getal2} is {uitkomst}");
        }
    }
}
