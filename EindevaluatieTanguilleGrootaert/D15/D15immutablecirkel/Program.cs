using System;

namespace D15.D15cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel(3.45);
            
            cirkel.GetOppervlakte();
            cirkel.GetOmtrek();

            PrintCirkel(cirkel);

            //Als je onderstaande lijn uit commentaar haalt zie je een compilefout die erop duid dat de straal niet aangepast kan worden.
            //cirkel.Straal = 5.0; 
        }
        static void PrintCirkel(Cirkel c)
        {
            Console.WriteLine($"Cirkel met straal {c.Straal}, omtrek {c.GetOmtrek()} en oppervlakte {c.GetOppervlakte()}.");
        }
    }
}
