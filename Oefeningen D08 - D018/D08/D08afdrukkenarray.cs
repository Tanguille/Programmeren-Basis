using System;

namespace D08
{
    class D08afdrukkenarray
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);

                if (i != a.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}




