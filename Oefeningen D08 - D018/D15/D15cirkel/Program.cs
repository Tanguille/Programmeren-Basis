using System;

namespace D15.D15cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            cirkel.Straal = (3.45);

            cirkel.GetOppervlakte();
            cirkel.GetOmtrek();

            PrintCirkel(cirkel);
        }
        static void PrintCirkel(Cirkel c)
        {
            Console.WriteLine($"Cirkel met straal {c.Straal}, omtrek {c.GetOmtrek()} en oppervlakte {c.GetOppervlakte()}.");
        }
    }
}
