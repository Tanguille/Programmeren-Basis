using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("De computer denkt aan een getal tussen 0 en 10." +
                "Welk getal denkt u dat het is? :");
            int getal = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int willekeurigGetal = rnd.Next(0, 11);

            if (willekeurigGetal == getal) {
                Console.WriteLine("Proficiat, u heeft goed geraden!");
            }

            else { Console.WriteLine($"Helaas, het getal was {willekeurigGetal}!"); }
        
        }
    }
}
