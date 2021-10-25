using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Geef een jaartal: ");
            int jaartal = int.Parse(Console.ReadLine());
            

            if (jaartal % 4 == 0 && (jaartal % 100 != 0 || jaartal % 400 == 0))
            {
                Console.WriteLine("Dit is een schrikkeljaar.");
            }
            else
            {
                Console.WriteLine("Dit is geen schrikkeljaar.");
            }
        }
    }
}
