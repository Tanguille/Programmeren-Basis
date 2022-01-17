using System;

namespace D11
{
    internal class D11dierenwissenarray
    {
        static void Main()
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            do
            {
                toonDieren(boerderijDieren);
                wisDierVanGebruiker(boerderijDieren);
            } while (true);
        }
        static void toonDieren(string[] boerderijDieren)
        {
            foreach (string dier in boerderijDieren)
            {
                if (dier == null)
                {
                    // toon GEWIST als we een null tegenkomen
                    Console.Write("GEWIST ");
                }
                else
                {
                    Console.Write(dier + " ");
                }
            }
            Console.WriteLine();
        }
        static void wisDierVanGebruiker(string[] boerderijDieren)
        {
            // vraag om een dier en bepaal de positie
            Console.Write("Welk dier wil je verwijderen : ");
            string tewissenDier = Console.ReadLine();
            int index = Array.IndexOf(boerderijDieren, tewissenDier);

            if (index != -1)
            {
                // wis dier
                boerderijDieren[index] = null;
            }
        }
    }
}
