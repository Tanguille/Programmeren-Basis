using System;

namespace D15.D15afstandtussenpunten
{
    internal class Punt
    {
        public double _x { get; }
        public double _y { get; }

        public Punt(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public static double GetAfstandTussen(Punt punt1, Punt punt2)
        {
            double resultX = Math.Pow(punt1._x - punt2._x, 2);
            double resultY = Math.Pow(punt1._y - punt2._y, 2);

            return Math.Sqrt(resultX + resultY);
        }
    }
}
