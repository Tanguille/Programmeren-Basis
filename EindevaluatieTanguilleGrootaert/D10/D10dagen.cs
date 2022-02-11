using System;

namespace D10
{
    internal class D10dagen
    {

        public static string[] maanden = {"januari", "februari", "maart", "april", "mei", "juni", "juli",
            "augustus", "september", "oktober", "november", "december"};
        public static int[] dagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main()
        {

            do
            {
                Console.Write("Maand?: ");
                int maand = int.Parse(Console.ReadLine());

                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());


                Console.WriteLine($"In {maanden[maand - 1]} van {jaar} zijn er {AantalDagen(maanden[maand - 1], jaar)} dagen.");
                Console.WriteLine();

            } while (true);
        }

        static int AantalDagen(string maand, int jaar)
        {
            int aantalDagen = 0;
            if (maand == "februari")
            {
                aantalDagen = AantalDagenFebruari(IsSchrikkeljaar(jaar));
            }
            else
            {
                for (int i = 0; i < maanden.Length; i++)
                {
                    if (maanden[i].Contains(maand))
                    {
                       aantalDagen = dagen[i];
                    }
                                    }
            }
            return aantalDagen;
        }

        static int AantalDagenFebruari(bool schrikkeljaar)
        {
            int aantalDagen = 28;
            if (schrikkeljaar)
            {
                aantalDagen++;
            }
            return aantalDagen;
        }

        static bool IsSchrikkeljaar(int jaartal)
        {
            return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }
    }
}