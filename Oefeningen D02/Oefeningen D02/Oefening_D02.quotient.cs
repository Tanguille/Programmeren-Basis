using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Geef een deeltal: ");
            //string deeltalalstekst = Console.ReadLine();
            double deeltal = double.Parse(Console.ReadLine());

            Console.Write("Geef een deler: ");
            //string deleralstekst = Console.ReadLine();
            double deler = double.Parse(Console.ReadLine());

            //Console.WriteLine("Quotient: " + deeltal / deler);

            if (deler == 0) {
                Console.WriteLine("Deling door nul wordt niet toegelaten.");
            }

            else { Console.WriteLine("Quotient: " + deeltal / deler); }
        }
    }
}
