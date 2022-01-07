using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12bertbevermettimespan
    {
        static void Main(string[] args)
        {
            Console.Write("Duw 2x achter elkaar zo snel mogelijk op dezelfde toets.");
            char key1 = Console.ReadKey(true).KeyChar;
            DateTime ticks1 = DateTime.Now;

            char key2 = Console.ReadKey(true).KeyChar;
            DateTime ticks2 = DateTime.Now;

            if (key1 == key2)
            {
                Console.WriteLine();
                TimeSpan ticksDelta = ticks2 - ticks1;               
                Console.WriteLine("De tijd ertussen bedroeg " + ticksDelta.TotalMilliseconds + " ms.");
            }
        }
    }    
}
