using System;

namespace D12
{
    internal class D12verjaardagen
    {

        static void Main(string[] args)
        {
            string[] maanden = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };
            int[] verjaardagenPerMaand = new int[12];
            int maandenIngevuld = 0;

            while (maandenIngevuld != 10)
            {
                Console.Write("Geef een verjaardag: ");
                string datum = Console.ReadLine();
                int maand;

                Console.WriteLine();
                if (int.TryParse(datum.Substring(3, 2), out maand))
                {
                    if (maand > 0 && maand < 13)
                    {
                        verjaardagenPerMaand[maand - 1]++;
                        maandenIngevuld++;
                    }
                    else
                    {
                        Console.WriteLine("Geen geldige maand.");
                    }
                }
                else
                {
                    Console.WriteLine("Niet correct ingevoerd. Probeer opnieuw.");
                }
            }
            for (int i = 0; i < 12; i++)
            {
                int verjaardagen = verjaardagenPerMaand[i];
                if (verjaardagen > 0)
                {
                    Console.WriteLine($"Verjaardagen in {maanden[i]}: {verjaardagen}");
                }
            }
        }
    }
}

