using System;

namespace D15.D15artikelmetprijs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikelmetprijs Artikelmetprijs1 = new Artikelmetprijs();
            Artikelmetprijs Artikelmetprijs2 = new Artikelmetprijs();

            Artikelmetprijs1.PrijsExclBTW = (100);
            Artikelmetprijs2.PrijsExclBTW = (100);

            Artikelmetprijs2.Btw = (6);

            PrintPrijs(Artikelmetprijs1);
            PrintPrijs(Artikelmetprijs2);
        }
        static void PrintPrijs(Artikelmetprijs a)
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
