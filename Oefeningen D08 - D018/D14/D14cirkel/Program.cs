using System;

namespace D14.D14cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            cirkel.SetStraal(3.45);

            cirkel.GetOppervlakte();
            cirkel.GetOmtrek();

            PrintCirkel(cirkel);
        }
        static void PrintCirkel(Cirkel c)
        {
            Console.WriteLine($"Cirkel met straal {c.GetStraal()}, omtrek {c.GetOmtrek()} en oppervlakte {c.GetOppervlakte()}.");
        }
    }
}
