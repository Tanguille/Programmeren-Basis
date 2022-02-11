using System;

namespace D13
{
    internal class D13gemeenteraad
    {
        static void Main()
        {
            // Voor fictieve gemeente X:
            int inwonersGemeente = 125;
            int[] lijstNummers = { 1, 2, 3, 4 };
            string[] lijsten = { "Groen", "Open Vld", "N-VA", "sp.a" };
            int[] stemcijfers = { 60, 30, 31, 4 };

            // Voor Gent (gemeenteraadsverkiezingen 2018): (3)
            // (vervang bovenstaande regels door onderstaande om voor deze gemeente uit te testen)
            /*
            int inwonersGemeente = 259570;
            int[] lijstNummers = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            string[] lijsten = { "spa.a-Groen", "N-VA", "CD&V", "VLAAMS BELANG", "Open Vld", "PVDA", "DUW.GENT", "MRP", "SPIEGEL Partij", "BE-ONE", "GENTSE BURGERS", "VMC", "PISS-OFF" };
            int[] stemcijfers = { 53179, 19167, 13979, 12354, 39879, 11178, 3229, 498, 329, 1709, 1633, 480, 931 };
            */

            // Vraag het aantal raadsleden voor de gemeenteraad op:
            //int raadsleden = Raadsleden(inwonersGemeente);

            // Vraag het aantal zetels (voor elke lijst) op:
           // int[] zetels = Zetels(raadsleden, lijsten, stemcijfers);

            //Print(lijstNummers, lijsten, stemcijfers, zetels);
        }

        static void Print(int[] lijstNummers, string[] lijsten, int[] stemcijfers, int[] zetels)
        {
            for (int i = 0; i < lijstNummers.Length; i++)
            {
                Console.WriteLine($"{lijstNummers[i],2}: {lijsten[i],15:d}: {zetels[i],2:d} zetels: {stemcijfers[i],6:d} stemmen");
            }
        }
        //static int Raadsleden(int inwoners)
      
    }
}

