using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Geef een getal: ");
            double getal = double.Parse(Console.ReadLine());

         

            if (getal >= 0) {
                Console.WriteLine(getal);
            }
            else { Console.WriteLine(-1 * getal); }
        }
    }
}
