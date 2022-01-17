namespace Rekeningkantoor
{
    internal class Kantoor
    {
        public Persoon Kantoorhouder { get; private set; }

        public Adres Adres { get; private set; }

        public Kantoor(Persoon kantoorhouder, Adres adres)
        {
           Kantoorhouder = kantoorhouder;
           Adres = adres;
        }
    }
}
