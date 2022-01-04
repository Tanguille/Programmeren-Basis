using System;

namespace D11
{
    internal class D11reversearray
    {
        static void Main()
        {
            string[] test0 = { }; // Duizend bommen en granaten Kuifje, een leeg array!
            string[] test1 = { "een" };
            string[] test2 = { "een", "twee" };
            string[] test3 = { "een", "twee", "drie" };
            string[] test4 = { "een", "twee", "drie", "vier" };
            string[] test5 = { "een", "twee", "drie", "vier", "vijf" };

            string[] woorden = test5;

            Console.WriteLine(string.Join(", ", woorden));
            Reverse(woorden);
            Console.WriteLine(string.Join(", ", woorden));
        }
        static void Reverse(string[] woorden)
        {
            string[] woordenReverse = new string[woorden.Length];
            Array.Copy(woorden, woordenReverse, woorden.Length);
            int j = woorden.Length - 1;
            for (int i = 0; i < woorden.Length; i++)
            {
                woorden[i] = woordenReverse[j];
                j--;
            }
        }
    }
}
