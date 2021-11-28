using System;

namespace ConsoleApp1
{
    class klinkersenmedeklinkers
    {
        static void Main(string[] args)
        {
            //aan deze oefening beginnen
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            int aantal = 0;
            foreach (char c in tekst)
            {
                if (c == 'e')
                {
                    aantal++;
                }
            }
            Console.WriteLine("'e' komt " + aantal + " keer voor.");

        }
    }
}
