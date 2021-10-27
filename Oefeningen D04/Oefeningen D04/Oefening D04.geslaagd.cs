using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Geef uw score op test 1: ");
            int scoreTest1 = int.Parse(Console.ReadLine());

            Console.Write("Geef uw score op test 2: ");
            int scoreTest2 = int.Parse(Console.ReadLine());

            Console.Write("Geef uw score op test 3: ");
            int scoreTest3 = int.Parse(Console.ReadLine());

            if ((((scoreTest1 + scoreTest2 + scoreTest3) / 3) >= 5) || 
               (scoreTest1 + scoreTest2 + scoreTest3 >= 18 && scoreTest1 > 4 && scoreTest2 > 4 && scoreTest3 > 4))
            {
                Console.WriteLine("U bent geslaagd.");
            }
            else
            {
                Console.WriteLine("U bent niet geslaagd.");
            }

        }
    }
}
