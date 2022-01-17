using System;

namespace D14.D14rechthoek
{
    internal class Rechthoek
    {
        private double _hoogte;
        private double _breedte;
        
        public void SetHoogte(double hoogte)
        {
            _hoogte = hoogte;
        }

        public double GetHoogte()
        { return _hoogte; }

        public void SetBreedte(double breedte)
        {
            _breedte = breedte;
        }

        public double GetBreedte()
        { return _breedte; }

        public double Oppervlakte()
        { return _hoogte * _breedte; }
    }
}
