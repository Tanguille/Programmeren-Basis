using System;

namespace D11
{
    internal class D11bevatwaarde
    {
        public static int[] uniekeGetallen = new int[5];
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Geef een getal #" + (i + 1) + ": ");
                string inputAlsTekst = Console.ReadLine();
                bool gelukt = int.TryParse(inputAlsTekst, out int getal);

                if (!gelukt || BevatWaarde(getal))
                {
                    i--;
                }
                else
                {
                    uniekeGetallen[i] = getal;
                }
            }
        }
        static bool BevatWaarde(int getal)
        {
            bool bevatWaarde = false;

            for (int i = 0; i < uniekeGetallen.Length; i++)
            {
                if (getal == uniekeGetallen[i])
                {
                    bevatWaarde = true;
                }
            }
            return bevatWaarde;
        }
    }
}
