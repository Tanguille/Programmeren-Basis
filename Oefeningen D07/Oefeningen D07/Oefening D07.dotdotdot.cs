using System;

namespace ConsoleApp1
{
    class dotdotdot
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();
            char index;
            for (int i = 0; i < tekst.Length; i++)
            {
                index = tekst[i];
                Console.Write(index + ".");
            }
        }
    }
}
