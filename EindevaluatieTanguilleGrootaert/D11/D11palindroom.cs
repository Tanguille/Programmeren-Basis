using System;

namespace D11
{
    internal class D11palindroom
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord: ");
            string woord = Console.ReadLine();
            Console.WriteLine(IsPalindroom(woord));
        }
        static bool IsPalindroom(string woord)
        {
            bool palindroom = false;

            if (ReverseText(woord) == woord && woord.Length != 0)
            {
                palindroom = true;
            }         
            return palindroom;
        }
        static string ReverseText(string woord)
        {
            char[] cArray = woord.ToCharArray();
            string reverseTekst = "";

            for (int i = woord.Length - 1; i > -1; i--)
            {
                reverseTekst += cArray[i];
            }
            return reverseTekst;
        }
    }
}
