using System;

namespace D11
{
    internal class D11charcount
    {
        static void Main(string[] args)
        {
            int aantal = GetCharCount("This is a local shop, for local people; there's nothing for you here..", 'o');

            Console.WriteLine("'o' komt " + aantal + " keer voor.");
        }
        static int GetCharCount(string tekst, char zoekChar)
        {
            int aantal = 0;

            foreach (char c in tekst)
            {
                if (c == zoekChar)
                {
                    aantal++;
                }
            }
            return aantal;
        }
    }
}
