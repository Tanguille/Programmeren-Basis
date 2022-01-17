using System;

namespace D10
{
    internal class D10printreeks
    {
        static void Main(string[] args)
        {
            PrintReeks(10, 15);
            PrintReeks(8, 3);
            PrintReeks(4, 4);

            static void PrintReeks(int getal1, int getal2)
            {
                int max = 0;
                int min = 0;

                if (getal1 > getal2)
                {
                    max = getal1;
                    min = getal2;
                }
                else
                {
                    max = getal2;
                    min = getal1;
                }
                int som = max - min;

                //array maken van min waarde tot max waarde 
                int[] reeks = new int[som + 1];

                for (int i = 0; i < som + 1; i++)
                {
                    reeks[i] = min;
                    min++;
                    if (min > max)
                    {
                        Console.Write(reeks[i]);
                    }
                    else
                    {
                        Console.Write(reeks[i] + " > ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
