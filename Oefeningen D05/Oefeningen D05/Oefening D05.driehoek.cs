using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rechthoekijde?: ");
            int zijde = int.Parse(Console.ReadLine());
            int breedteZijde = zijde;
            int hoogteTeller = 0;
            do
            {
                int breedteTeller = 0;
                do
                {
                    Console.Write("*");
                    breedteTeller = breedteTeller + 1;                   
                } while (breedteTeller < breedteZijde);
                Console.WriteLine();
                hoogteTeller = hoogteTeller + 1;
                breedteZijde = breedteZijde - 1;
            } while (hoogteTeller < zijde);


        }
    }
}

