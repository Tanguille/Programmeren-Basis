using System;

namespace Oefening_D01
{
    class D01BMI

    {
        static void Main(string[] args)
        {
            int lengteInCm = 182;
            int gewichtInKg = 72 ;
            double lengteInM = lengteInCm / 100.0;
            double bmi = gewichtInKg /(lengteInM*lengteInM);

            Console.WriteLine(bmi);
        }
    }
}
