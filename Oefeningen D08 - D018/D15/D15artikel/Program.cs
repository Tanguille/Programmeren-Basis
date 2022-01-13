using System;

namespace D15.D15artikel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikel artikel1 = new Artikel();
            Artikel artikel2 = new Artikel();

            artikel1.PrijsExclBTW = (100);
            artikel2.PrijsExclBTW = (100);

            artikel2.Btw = (6);

            PrintPrijs(artikel1);
            PrintPrijs(artikel2);
        }
        static void PrintPrijs(Artikel a)
        {
            decimal prijsExclBTW = a.PrijsExclBTW;
            decimal BTW = a.Btw;
            decimal prijsInclBTW = a.PrijsInclBTW;

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
