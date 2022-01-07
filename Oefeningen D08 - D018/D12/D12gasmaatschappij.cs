using System;


namespace D12
{
    internal class D12gasmaatschappij
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de beginstand: ");
            int beginStand = int.Parse(Console.ReadLine());

            Console.Write("Geef de eindstand: ");
            int eindStand = int.Parse(Console.ReadLine());

            Console.WriteLine("De totale kostprijs is " + Math.Round(KostprijsBerekenen(VerbruikBerekenen(beginStand, eindStand)), 2, MidpointRounding.AwayFromZero) + " EUR");
        }
        static int VerbruikBerekenen(int beginStand, int eindStand)
        {
            int verbruik = 0;

            if (eindStand > beginStand)
            {
                verbruik = eindStand - beginStand;
            }
            else
            {
                int maxStand = 999999;
                eindStand += maxStand;
                verbruik = eindStand - beginStand;
            }
            return verbruik;
        }
        static decimal KostprijsBerekenen(int verbruik)
        {
            decimal kostprijs1000 = 1000.0m * 0.34m;
            decimal verbruikDec = verbruik;
            decimal kostprijs = 0;
            if (verbruik < 1000)
            {
                kostprijs = verbruikDec * 0.34m;
            }
            else
            {
                decimal verbruikExtra = verbruikDec - 1000.0m;
                kostprijs = (verbruikExtra * 0.31m) + kostprijs1000;
            }
            return kostprijs;
        }
    }
}
