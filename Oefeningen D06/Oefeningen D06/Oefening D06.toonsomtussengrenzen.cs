using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            
            Console.Write("Geef de ondergrens: ");
            int ondergrens = int.Parse(Console.ReadLine());

            Console.Write("Geef de bovengrens: ");
            int bovengrens = int.Parse(Console.ReadLine());

            for (int i = ondergrens + 1; i < bovengrens; i++)
            {
                som = som + i;
                Console.Write(i);
                if (i < (bovengrens - 1))
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine(" = " + som);
        }
        }
    }

    


