using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Geef een geheel getal :");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef een ander geheel getal :");
            int getal2 = int.Parse(Console.ReadLine());

            int a = getal1;
            int b = getal2;
            int kleinste = Math.Min(a, b);

            Console.Write($"Het kleinste getal is {kleinste}.");
        }
    }
}
