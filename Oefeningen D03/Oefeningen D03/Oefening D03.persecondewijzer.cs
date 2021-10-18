using System;

namespace Oefeningen_D02 {
    class D02som {
        static void Main(string[] args) {
            Console.Write("Geef een aantal seconden: ");
            int secondenInvoer = int.Parse(Console.ReadLine());

            int aantalUur = secondenInvoer / 3600;
            int aantalMinuten = secondenInvoer % 3600 / 60;
            int resterendeSeconden = secondenInvoer - (aantalUur * 3600 + aantalMinuten * 60); 


            Console.Write($"Dit aantal seconden komt overeen met {aantalUur} uur, {aantalMinuten} minuten en {resterendeSeconden} seconden.");
        }
    }
}
