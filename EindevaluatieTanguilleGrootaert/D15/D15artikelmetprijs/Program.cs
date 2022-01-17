using System;

namespace D15.D15artikelmetprijs
{
    internal class Program
    {
        static void Main()
        {
            // Test de constructor met één parameter:
            Artikel artikel1 = new Artikel(100m);
            Console.WriteLine(artikel1.PrijsExclusiefBtw == 100m);    // zou true moeten opleveren
            Console.WriteLine(artikel1.BtwPercentage == 21m);         // zou true moeten opleveren
            Console.WriteLine(artikel1.PrijsInclusiefBtw() == 121m);  // zou true moeten opleveren

            // Test of de __setters__ nog correct functioneren:
            artikel1.PrijsExclusiefBtw = 1000m;
            artikel1.BtwPercentage = 6m;
            Console.WriteLine(artikel1.PrijsExclusiefBtw == 1000m);   // zou true moeten opleveren
            Console.WriteLine(artikel1.BtwPercentage == 6m);          // zou true moeten opleveren
            Console.WriteLine(artikel1.PrijsInclusiefBtw() == 1060m); // zou true moeten opleveren

            // Test de constructor met twee parameters:
            Artikel artikel2 = new Artikel(200m, 6m);
            Console.WriteLine(artikel2.PrijsExclusiefBtw == 200m);    // zou true moeten opleveren
            Console.WriteLine(artikel2.BtwPercentage == 6m);          // zou true moeten opleveren
            Console.WriteLine(artikel2.PrijsInclusiefBtw() == 212m);  // zou true moeten opleveren

            // Test uit of de prijs exclusief BTW wel verplicht is,
            // volgende regel code zou dan ook een compile-fout moeten opleveren:
            //Artikel artikel3 = new Artikel();
            // Zet bovenstaande regel in commentaar indien hij daadwerkelijk een
            // compile-fout oplevert, dan heb je bereikt wat de bedoeling was
        }
    }
}
