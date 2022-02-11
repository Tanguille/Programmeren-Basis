using System;

namespace D11
{
    internal class D11getalinput
    {
        static void Main()
        {
            int getal = GetGetal(1, 100);
            Console.WriteLine($"U koos voor {getal}");
        }
        static int GetGetal(int min, int max)
        {
            int getal = 0;
            do
            {
                Console.Write($"Geef een getal van {min} t.e.m. {max}: ");
                string getalAlsTekst = Console.ReadLine();
                bool geldig = int.TryParse(getalAlsTekst, out getal);

            } while (getal < min || getal > max || getal == 0);

            return getal;
        }
    }
}
