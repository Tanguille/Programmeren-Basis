using System;
namespace D13
{
    internal class D13morsebeep
    {
        static void Main(string[] args)
        {                  
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key >= ConsoleKey.A && cki.Key <= ConsoleKey.Z)
                {

                }
            }
        }
        static void Morse(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        }
        static void KorteBeep()
        {
            const int frequentie = 750;
            Console.Beep(frequentie, 500);
            System.Threading.Thread.Sleep(250);
        }
        static void LangeBeep()
        {
            const int frequentie = 750;
            Console.Beep(frequentie, 1000);
            System.Threading.Thread.Sleep(250);
        }
    }
}
