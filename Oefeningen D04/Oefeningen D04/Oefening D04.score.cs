using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef uw score in % : ");
            int score = int.Parse(Console.ReadLine());

            if (score > 82)
            {
                Console.WriteLine("A");
            }
            else if (score > 67)
            {
                Console.WriteLine("B");
            }
            else if (score > 52)
            {
                Console.WriteLine("C");
            }
            else if (score > 37)
            {
                Console.WriteLine("D");
            }
            else if (score > 22)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
    
