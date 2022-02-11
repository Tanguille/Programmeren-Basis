namespace D15.D15stellingverhuur
{
    public class Levering
    {
        public string Adres { get; }
        public int AfstandInKm { get; }

        public Levering(string adres, int afstandInKm)
        {
            Adres = adres;
            AfstandInKm = afstandInKm;
        }
    }
}
