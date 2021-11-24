using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het aantal sterretjes: ");
            int aantal = int.Parse(Console.ReadLine());

            for (int i = 0; i < aantal; i++) 
            {
                Console.Write("*");
            }
        }
        }
    }

    


