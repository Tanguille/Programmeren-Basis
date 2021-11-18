using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            for (int i = 0; i < 100; i++)
            {
                int kwadraat = i * i;
                som = som + kwadraat;
            }
            Console.WriteLine($"De som van de kwadraten in [1-10] is {som}");
        }
        }                       
        }
    


