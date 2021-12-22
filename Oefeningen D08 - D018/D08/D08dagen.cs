using System;

namespace D08
{
    class D08dagen
    {
        static void Main(string[] args)
        {
            string[] dagen = new string[7]
            {"ma","di","wo","do","vr","za","zo"};

            Console.Write($"({dagen.Length} elementen): ");
            for (int index = 0; index < dagen.Length; index++)
            {
                Console.Write(dagen[index] + " ");
            }
        }
    }
}
