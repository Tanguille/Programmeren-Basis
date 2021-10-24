using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een dagnummer (1-365): ");
            int dagnummer = int.Parse(Console.ReadLine());

                       
            if (dagnummer <= 31)
            {
                Console.WriteLine("Januari");
            }
            else if (dagnummer <= 59)
            {
                Console.WriteLine("Februari");
            }
            else if (dagnummer <= 90)
            {
                Console.WriteLine("Maart");
            }
            else if (dagnummer <= 120)
            {
                Console.WriteLine("April");
            }
            else if (dagnummer <= 151)
            {
                Console.WriteLine("Mei");
            }
            else if (dagnummer <= 181)
            {
                Console.WriteLine("Juni");
            }
            else if (dagnummer <= 212)
            {
                Console.WriteLine("Juli");
            }
            else if (dagnummer <= 243)
            {
                Console.WriteLine("Augustus");
            }
            else if (dagnummer <= 273)
            {
                Console.WriteLine("September");
            }
            else if (dagnummer <= 304)
            {
                Console.WriteLine("Oktober");
            }
            else if (dagnummer <= 334)
            {
                Console.WriteLine("November");
            }
            else if (dagnummer <= 365)
            {
                Console.WriteLine("December");
            }
        }
    }
}
    
