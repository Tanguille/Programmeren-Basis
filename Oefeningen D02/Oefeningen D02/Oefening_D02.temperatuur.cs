using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de temperatuur in °Fahrenheit tot op 0,1°C nauwkeurig: ");
            string temperatuurinFalstekst = Console.ReadLine();
            double temperatuurinF = double.Parse(temperatuurinFalstekst);

            
            double temperatuurinC = 5.0 / 9 * (temperatuurinF - 32); ;

            Console.WriteLine("De temperatuur bedraagt " + temperatuurinC + "°C.");
        }
    }
}