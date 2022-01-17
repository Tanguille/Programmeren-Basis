namespace Rekeningkantoor
{
    internal class Persoon
    {
        public string Voornaam { get; private set; }
        public string Familienaam { get; private set; }
        public Adres Adres { get; private set; } 

        public Persoon(string voornaam, string familienaam, Adres adres)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Adres = adres;
        }
    }
}
