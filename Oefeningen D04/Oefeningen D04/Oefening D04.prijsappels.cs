using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Aantal Kg aan te kopen appels? ");
            double gewichtInKg = double.Parse(Console.ReadLine());

           
            double prijs;
            if (gewichtInKg >= 20)
            {
             prijs = gewichtInKg * 2;
            }
            else if (gewichtInKg >= 15)
            {
             prijs = gewichtInKg * 2.5;
            }
            else
            {
                prijs = gewichtInKg * 3;
            }
            
            Console.WriteLine($"Prijs: {prijs}");
        }
    }
}
    
