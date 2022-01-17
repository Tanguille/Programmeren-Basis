using System;

namespace D12
{
    internal class D12bertbeverzondertimespan
    {
        static void Main(string[] args)
        {
            Console.Write("Duw 2x achter elkaar zo snel mogelijk op dezelfde toets.");
            char key1 = Console.ReadKey(true).KeyChar;
            long ticks1 = DateTime.Now.Ticks;

            char key2 = Console.ReadKey(true).KeyChar;
            long ticks2 = DateTime.Now.Ticks;

            if (key1 == key2)
            {
                Console.WriteLine();
                long ticksDelta = ticks2 - ticks1;
                long aantalMS = ticksDelta / 1000;
                Console.WriteLine("De tijd ertussen bedroeg " + aantalMS + " ms.");
            }
        }
    }
}
