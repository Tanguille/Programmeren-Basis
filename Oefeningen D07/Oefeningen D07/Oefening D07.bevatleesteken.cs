using System;

namespace ConsoleApp1
{
    class bevatleesteken
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            bool leesteken = false;
            foreach ( char c in tekst)
            {
                leesteken = Char.IsPunctuation(c);
                if (leesteken)
                {
                    Console.WriteLine("De tekst bevat minstens 1 leesteken.");
                    
                }
            }
            if (leesteken == false)
            {
                Console.WriteLine("De tekst bevat geen enkel leesteken.");
            }

        }
    }
}
