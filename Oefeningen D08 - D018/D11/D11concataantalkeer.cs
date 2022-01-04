using System;


namespace D11
{
    internal class D11concataantalkeer
    {
        static void Main()
        {
            string output = ConcatAantalKeer("*-", 4);
            Console.WriteLine(output);
        }
        static string ConcatAantalKeer(string input, int aantal)
        {
            string output = "";
            for (int i = 0; i < aantal; i++)
            {
                Console.Write(input);
            }
            return output;
        }
    }
}
