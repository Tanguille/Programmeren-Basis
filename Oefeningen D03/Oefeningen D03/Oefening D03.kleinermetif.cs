using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Geef een geheel getal :");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef een ander geheel getal :");
            int getal2 = int.Parse(Console.ReadLine());

         
            if (getal1 > getal2) {
                Console.WriteLine($"{getal2} is kleiner.");
            }

            else { Console.WriteLine($"{getal1} is kleiner."); }
        
        }
    }
}
