using System;


namespace D10
{
    internal class D10dagenfebruari
    {
        static void Main()
        {
            do
            {
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                Console.WriteLine($"In februari van {jaar} zijn er {AantalDagen(IsSchrikkeljaar(jaar))} dagen.");
                Console.WriteLine();
            } while (true);
        }
        static int AantalDagen(bool schrikkeljaar)
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
