using System;

namespace D09
{
    class D09maximumtemperatuur
    {
        static void Main(string[] args)
        {
            double[] meetwaarden = { 13.4, 12.1, 10.8, 10.8, 10.3, 8.9, 7.9, 7.8, 7.4, 7.2, 6.4, 9.7, 13.7, 17.2, 19.6, -9999.0, -9999.0, 22.4, 22.7, 22.8, 22.3, 18.4 };
           
            double laagsteTemp = 9000.0;
            double hoogsteTemp = -9000.0;

            for (int i = 0; i < meetwaarden.Length; i++)
            {
                if (meetwaarden[i] <= laagsteTemp && meetwaarden[i] > -9999.0)
                {
                    laagsteTemp = meetwaarden[i];
                }
                if (meetwaarden[i] >= hoogsteTemp && meetwaarden[i] < 9999.0)
                {
                    hoogsteTemp = meetwaarden[i];
                }
            }
            if (laagsteTemp == 9000.0 && hoogsteTemp == -9000.0)
            {
                Console.WriteLine("Er zitten geen geldige meetwaarden tussen vandaag.");
            }
            else
            {
                Console.WriteLine($"Minimumtemperatuur: {laagsteTemp}");
                Console.WriteLine($"Maximumtemperatuur: {hoogsteTemp}");
            }
        }
    }
}