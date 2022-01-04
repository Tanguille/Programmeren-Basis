using System;

namespace D11
{
    class D11kader
    {
        static void Main(string[] args)
        {
            Console.Write("Schrijf tekst: ");
            string input = Console.ReadLine();

            ToonInKader(input);
        }
        static void ToonInKader(string input)
        {
            for (int i = 0; i < input.Length + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("* " + input + " *");
            for (int i = 0; i < input.Length + 4; i++)
            {
                Console.Write("*");
            }
        }
    }
}
