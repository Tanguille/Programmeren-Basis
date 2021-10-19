using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lengte in cm: ");
            double lengteInCm = double.Parse(Console.ReadLine());

            Console.Write("Gewicht in kg: ");
            int gewichtInKg = int.Parse(Console.ReadLine());

            double bmi = gewichtInKg / Math.Pow(lengteInCm / 100, 2);

            string categorie = "normaal gewicht";
            if (bmi >= 40)
            {
                categorie = "ernstige zwaarlijvigheid";
            }
            else if (bmi >= 30)
            {
                categorie = "zwaarlijvigheid";
            }
            else if (bmi >= 25)
            {
                categorie = "overgewicht";
            }
            else if (bmi < 18.5)
            {
                categorie = "ondergewicht";
            }

            Console.WriteLine($"BMI: {bmi} ({categorie})");
        }
    }
}
    
