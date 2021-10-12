using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef je leeftijd: ");
            string leeftijdalstekst = Console.ReadLine();
            int leeftijd = int.Parse(leeftijdalstekst);

            if
                (leeftijd >= 18) {
                Console.WriteLine("Je bent wel volwassen.");
            }
            else {
                Console.WriteLine("Je bent niet volwassen.");
            }
        }
    }
}
