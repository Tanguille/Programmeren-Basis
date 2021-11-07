using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lengte zijde?: ");
            int zijde = int.Parse(Console.ReadLine());
                        
            int hoogteTeller = 0;
            do
            {
                int breedteTeller = 0;  
                do
                {
                    Console.Write("*");
                    breedteTeller = breedteTeller + 1;
                } while (breedteTeller < zijde);
              Console.WriteLine();
              hoogteTeller = hoogteTeller + 1;
            } while (hoogteTeller < zijde);
                        
                      
        }
    }
}
    
