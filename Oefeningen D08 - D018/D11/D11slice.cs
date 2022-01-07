using System;

namespace D11
{
    internal class D11slice
    {
        static void Main()
        {
            int[] getallen = { 0, 1, 2, 3, 4, 5, 6 }; // makkelijke getallen om te testen en te debuggen!

            int[] testHead0 = Slice(getallen, 0, 0);
            int[] testMiddle0 = Slice(getallen, 3, 0);
            int[] testTail0 = Slice(getallen, getallen.Length - 1, 0);

            int[] testHead1 = Slice(getallen, 0, 1);
            int[] testMiddle1 = Slice(getallen, 3, 1);
            int[] testTail1 = Slice(getallen, getallen.Length - 1, 1);

            int[] testHead2 = Slice(getallen, 0, 2);
            int[] testMiddle2 = Slice(getallen, 3, 2);
            int[] testTail2 = Slice(getallen, getallen.Length - 2, 2);

            int[] testComplete = Slice(getallen, 0, getallen.Length);

            int[] array = testHead0;


            string output = String.Join("-", array);
            Console.WriteLine(output);
        }
        static int[] Slice(int[] values, int startIndex, int length)
        {
            int[] slice = new int[length];
            for (int i = 0; i < length ; i++)
            {
                slice[i] = values[startIndex + i]; 
            }
            return slice;
        }
    }
}
