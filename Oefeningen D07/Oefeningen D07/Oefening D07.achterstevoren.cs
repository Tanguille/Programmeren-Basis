using System;

namespace ConsoleApp1
{
    class achterstevoren
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();
            char index;
            for (int i = tekst.Length-1; i >= 0; i--)
            {
                index = tekst[i];
                Console.Write(index);
            }
        }
    }
}
