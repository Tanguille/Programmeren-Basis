using System;

namespace ConsoleApp1
{
    class zoekennaarvorige
    {
        static void Main(string[] args)
        {
            string a, b; int c = 0, d = 0;
            Console.Write("Geef een tekst : ");
            a = Console.ReadLine();
            Console.Write("Geef de zoektekst : ");
            b = Console.ReadLine();
            for (int i = 0; i < a.Length / b.Length; i++)
            {
                if (a.Substring(c, b.Length).Equals(b))
                {
                    d++;
                }
                c += b.Length;
            }




            Console.Write($"De zoektekst komt {d} keer voor");










        }
    }
}


