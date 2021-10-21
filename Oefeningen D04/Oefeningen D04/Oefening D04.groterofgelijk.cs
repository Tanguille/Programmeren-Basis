using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een getal: ");
           int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef een ander getal: ");
            int getal2 = int.Parse(Console.ReadLine());

            if (getal1 == getal2)
            {
                Console.WriteLine("Ze zijn gelijk");
            }
            else if (getal1 > getal2)
            {
                Console.WriteLine("Het eerste is groter");
            }
            else if (getal2 > getal1)
            {
                Console.WriteLine("Het tweede is groter");
            }    
             
         
            
            
        }
    }
}
    
