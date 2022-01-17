using System;

namespace D15.D15getafstandtussenoverlapt
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
        public double GetAfstandTussen(Punt punt2)
        {
            double resultX = Math.Pow(this.X - punt2.X, 2);
            double resultY = Math.Pow(this.Y - punt2.Y, 2);

            return Math.Sqrt(resultX + resultY);
        }      
    }
}
