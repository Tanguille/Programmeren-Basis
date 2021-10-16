using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een getal: ");
            double getal = double.Parse(Console.ReadLine());

            double absoluutGetal = Math.Abs(getal);

            Console.WriteLine(absoluutGetal);      
           
        }
    }
}
