using System;

namespace D14.D14bankrekening
{
    internal class Program
    {
        static void Main()
        {
            Bankrekening b1 = new Bankrekening();
            Bankrekening b2 = new Bankrekening();

            decimal bedrag = 100m;

            b1.SchrijfOver(b2, bedrag);


            Console.WriteLine(b1.Saldo() == -100m); // zou true moeten geven
            Console.WriteLine(b2.Saldo() == 100m);  // zou true moeten geven
        }
    }
}
