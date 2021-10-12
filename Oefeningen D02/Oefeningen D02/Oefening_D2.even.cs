using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Geef een geheel getal: ");
            int getal = int.Parse(Console.ReadLine());

            double even = (getal % 2);

            if (even ==  0) {
                Console.WriteLine("Het getal is even.");
            }
            else { Console.WriteLine("Het getal is oneven."); }
        }
    }
}
