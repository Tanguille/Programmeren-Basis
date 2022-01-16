using System;

namespace D15.D15cirkelpunt
{
    class Punt
    {
        public double X { get; }
        public double Y { get; }

        public Punt(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static double GetAfstandTussen(Punt punt1, Punt punt2)
        {
            double resultX = Math.Pow(punt1.X - punt2.X, 2);
            double resultY = Math.Pow(punt1.Y - punt2.Y, 2);

            return Math.Sqrt(resultX + resultY);
        }      
    }
}
