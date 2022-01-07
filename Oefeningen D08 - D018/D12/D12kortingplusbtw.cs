using System;


namespace D12
{
    internal class D12kortingplusbtw
    {      
        static void Main(string[] args)
        {
            Console.Write("Geef het bedrag excl. BTW (2 cijfers na de komma): ");
            decimal bedrag = decimal.Parse(Console.ReadLine());

            Console.Write("Geef de korting (in %): ");
            decimal korting = decimal.Parse(Console.ReadLine());

            Console.Write("Geef het btw-tarief (in %): ");
            decimal btw = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            //begin output (Als ik meer tijd had had ik hiervoor een method gemaakt)
            decimal exclBTW = bedrag;
            string exclBTWstring = "excl. BTW: " + Math.Round(exclBTW, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - exclBTWstring.Length;
            Console.WriteLine(exclBTWstring);

            decimal kortingBedrag = bedrag * (korting / 100);
            string kortingString = "korting: " + Math.Round(kortingBedrag, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - kortingString.Length;
            Console.WriteLine(kortingString);

            decimal btwBedrag = (bedrag - kortingBedrag) * (btw / 100);
            string btwString = "BTW: " + Math.Round(btwBedrag, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - btwString.Length;
            Console.WriteLine(btwString);

            decimal inclBTW = exclBTW - kortingBedrag + btwBedrag;
            string inclBTWString = "incl. BTW: " + Math.Round(inclBTW, 2, MidpointRounding.AwayFromZero);
            Console.CursorLeft = Console.BufferWidth - inclBTWString.Length;
            Console.WriteLine(inclBTWString);
        }
    }
}
