using System;

namespace D12
{
    internal class D12kapitaalwelafgerond
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een bedrag: ");
            decimal bedrag = decimal.Parse(Console.ReadLine());

            Console.Write("Geef de interestvoet (in %): ");
            decimal interestvoet = decimal.Parse(Console.ReadLine());

            InterestBerekenen(bedrag, interestvoet);
        }
        static void InterestBerekenen(decimal bedrag, decimal interestvoet)
        {
            decimal eindkapitaal = bedrag;

            for (decimal i = 0; i < 21; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Jaar {i}: {bedrag}");
                }
                else
                {
                    eindkapitaal += Math.Round(eindkapitaal, MidpointRounding.AwayFromZero)  * (interestvoet / 100);
                    Console.WriteLine($"Jaar {i}: {eindkapitaal,0:f2}");
                }
            }
        }
    }
}
