using System;

namespace ConsoleApp1
{
    class begintmethoofdletter
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            bool hoofdletter = false;
            char beginletter = tekst[0];

                hoofdletter = Char.IsUpper(beginletter);

                if (hoofdletter)
                {
                    Console.WriteLine("De tekst start met een hoofdletter.");

                }
                else
                {
                Console.WriteLine("De tekst start met een kleine letter.");
                }

        }
    }
}
