using System;

namespace D12.D12soortenafrondingen
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] g = { 7.4m, 7.5m, 7.6m, -7.4m, -7.5m, -7.6m };

            foreach (decimal d in g)
            {
                decimal mC = Math.Ceiling(d);

                decimal mF = Math.Floor(d);

                decimal mR = Math.Round(d);

                decimal mRAFZ = Math.Round(d, MidpointRounding.AwayFromZero);

                Console.WriteLine($"mC = {mC}, mF = {mF}, mR = {mR}, mRAFZ = {mRAFZ},");
            }
        }
    }
}
