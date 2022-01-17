using System;

namespace D15.D15cirkel
{
    internal class Cirkel
    {
        public double Straal { get; }
        private double _pi = Math.PI;

        public Cirkel(double straal)
        {
            Straal = straal;
        }

        public double GetOmtrek()
        { return (2 * Straal) * _pi; }

        public double GetOppervlakte()
        {
            return Math.Pow(Straal, 2) * _pi;
        }
    }
}
