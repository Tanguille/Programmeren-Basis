using System;

namespace Figuren
{
    internal class Cirkel
    {
        private double _pi = Math.PI;
        public double Straal { get; }

        public Punt Middelpunt { get; private set; }

        public Cirkel(double x, double y, double straal)
        {
            Straal = straal;
            Middelpunt = new Punt(x, y);
        }

        public double GetOmtrek()
        { return (2 * Straal) * _pi; }

        public double GetOppervlakte()
        { return Math.Pow(Straal, 2) * _pi; }

        public void VerplaatsNaar(int x, int y)
        { Middelpunt = new Punt(x, y); }

        public bool Bevat(Punt p)
        {
            if (Punt.GetAfstandTussen(Middelpunt, p) <= Straal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Overlapt(Cirkel c1, Cirkel c2)
        {
            double afstandStralen = c1.Straal + c2.Straal;
            if (Punt.GetAfstandTussen(c1.Middelpunt, c2.Middelpunt) < afstandStralen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
