using System;


namespace D10
{
    internal class D10bevat
    {
        static void Main(string[] args)
        {
            string[] dieren = { "hond", "kat", "olifant", "krokodil" };

            Console.WriteLine(Bevat(dieren, "papegaai"));
            Console.WriteLine(Bevat(dieren, "olifant"));

        }
        static bool Bevat(string[] dieren, string dier)
        {

            bool gevonden = false;

            string dierKlein = dier.ToLower();

            for (int i = 0; i < dieren.Length; i++)
            {
                if (dierKlein == dieren[i])
                {
                    gevonden = true;
                    break;
                }
            }
            return gevonden;
        }
    }
}
