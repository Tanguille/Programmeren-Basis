using System;

namespace D10
{
    internal class D10toongetallen
    {
        static void Main(string[] args)
        {
            int[] getallen = { 4, 7, 9, 34, 2, 56, 34, 78 };
            ToonGetallen(getallen);

        }
        static void ToonGetallen(int[] getallen)
        {
            for (int i = 0; i < getallen.Length; i++)
            {
                if (i == getallen.Length - 1)
                {
                    Console.Write(getallen[i]);
                }
                else
                {
                    Console.Write(getallen[i] + ", ");
                }
            }
        }
    }
}
