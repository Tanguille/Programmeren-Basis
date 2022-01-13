using System;


namespace D14.D14cirkel
{
    internal class Cirkel
    {
        private double _straal;
        private double _pi = Math.PI;

        public void SetStraal(double straal)
        {
            _straal = straal;
        }

        public double GetStraal()
        { return _straal; }

        public double GetOmtrek()
        { return (2 * _straal) * _pi; }

        public double GetOppervlakte()
        {
            return Math.Pow(_straal, 2) * _pi;
        }
    }
}
