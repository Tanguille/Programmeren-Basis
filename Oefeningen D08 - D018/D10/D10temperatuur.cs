using System;

namespace D10
{
    class D10temperatuur
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de temperatuur in °Fahrenheit tot op 0,1°C nauwkeurig: ");
            double temperatuurinF = double.Parse(Console.ReadLine());

            Console.WriteLine("De temperatuur bedraagt " + ConvertFToC(temperatuurinF) + "°C.");


        }
        static double ConvertFToC(double temperatuurinF)
        {
            double temperatuurinC = 5.0 / 9 * (temperatuurinF - 32);
            return temperatuurinC;
        }
    }
}