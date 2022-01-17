using System;

namespace D14.D14artikel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikel artikel1 = new Artikel();
            Artikel artikel2 = new Artikel();

            artikel1.SetPrijsExclBTW(100);
            artikel2.SetPrijsExclBTW(100);

            artikel2.SetBTW(6);

            PrintPrijs(artikel1);
            PrintPrijs(artikel2);
        }
        static void PrintPrijs(Artikel a)
        {
            decimal prijsExclBTW = a.GetPrijsExclBTW();
            decimal BTW = a.GetBTW();
            decimal prijsInclBTW = a.GetPrijsInclBTW();

            string exclBTWstring = "excl. BTW: " + Math.Round(prijsExclBTW, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - exclBTWstring.Length;
            Console.WriteLine(exclBTWstring);

            string btwString = "BTW: " + Math.Round(BTW * 100, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - btwString.Length;
            Console.WriteLine(btwString);

            string inclBTWString = "incl. BTW: " + Math.Round(prijsInclBTW, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - inclBTWString.Length;
            Console.WriteLine(inclBTWString);

            Console.WriteLine(); //visueel
        }
    }
}
