namespace D15.D15rechthoek
{
    internal class Rechthoek
    {
        public double Hoogte { get; set; }
        public double Breedte { get; set; }

        public double Oppervlakte()
        { return Hoogte * Breedte; }
    }
}
