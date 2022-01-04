using System;


namespace D11
{
    internal class D11reversetext
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string input = Console.ReadLine();

            Console.WriteLine(ReverseText(input));          
        }
        static string ReverseText(string tekst)
        {
            char[] cArray = tekst.ToCharArray();           
            string reverseTekst = "";

            for (int i = tekst.Length - 1; i > -1 ; i--)
            {
                reverseTekst += cArray[i];
            }
            return reverseTekst;
        }
    }
}
