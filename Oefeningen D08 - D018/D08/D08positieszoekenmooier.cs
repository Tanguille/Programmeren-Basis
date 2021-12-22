using System;

namespace D08
{
    class D08positieszoekenmooier
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

            Console.Write("Wat wenst u te zoeken?: ");
            int zoekterm = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(a, zoekterm);

            if (index < 0)
            {
                Console.WriteLine("De zoekterm werd niet gevonden.");
            }
            else
            {
                Console.WriteLine($"{zoekterm} werd gevonden op positie {index+1}");
            }
        }
    }
}
