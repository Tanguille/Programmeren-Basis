using System;

namespace D09
{
    class D09getalfrequentie
    {
        static void Main(string[] args)
        {
            int[] aantallen = new int[11];
           
            do
            {
                Console.Write("Geef een getal in van 0 t.e.m. 10 (Typ stop om te stoppen): ");
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                    int getal = int.Parse(input);
                    aantallen[getal - 1]++;
                }

            } while (true);

            for (int i = 0; i < aantallen.Length-1; i++)
            {
                if (aantallen[i] > 0)
                {
                    Console.WriteLine($"{i + 1} kwam {aantallen[i]} keer voor.");
                }
            }
        }
    }
}
