using System;

namespace D09
{
    class D09herkansing
    {
        static void Main(string[] args)
        {
            int[] puntenlijst = { 13, 16, 13, 18, 8, 12, 15, 3, 4, 11, 17, 18 };
            bool herkansingNodig = false;

            for (int i = 0; i < puntenlijst.Length; i++)
            {
                if (puntenlijst[i] <= 10)
                {
                    herkansingNodig = true;
                    break;
                }
            }
            if (herkansingNodig)
            {
                Console.WriteLine("Er is een herkansing nodig.");
            }
            else
            {
                Console.WriteLine("Er is geen herkansing nodig.");
            }
        }
    }
}
