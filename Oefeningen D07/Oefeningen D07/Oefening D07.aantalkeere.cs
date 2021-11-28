using System;

namespace ConsoleApp1
{
    class aantalkere
    {
        static void Main(string[] args)
        {

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
