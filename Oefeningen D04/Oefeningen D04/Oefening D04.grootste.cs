using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Geef een getal: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef nog een getal: ");
            int getal2 = int.Parse(Console.ReadLine());

            Console.Write("Geef nog een getal: ");
            int getal3 = int.Parse(Console.ReadLine());

            int grootste1 = Math.Max(getal1, getal2);
            int grootste2 = Math.Max(grootste1, getal3);

            Console.WriteLine($"Het grootste getal van {getal1}, {getal2} en {getal3} is {grootste2}.");
        }
    }
}
