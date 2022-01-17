using System;

namespace Rekeningkantoor
{
    internal class D15rekeningkantoormieke
    {
        static void Main(string[] args)
        {
            //zie folder "Rekeningkantoor" voor klasses

            Persoon jan = new Persoon("Jan", "Janssens", new Adres("Koekoekstraat", "70", "9090", "Melle"));
            Persoon mieke = new Persoon("Mieke", "Mickelsen", new Adres("Kerkstraat", "12", "8000", "Brugge"));
            
            Kantoor kantoorMieke = new Kantoor(mieke, mieke.Adres);

            Rekening rJan = new Rekening("BE11 2222 3333 4444", 120.0, kantoorMieke, jan);

            //voorbeeld 1
            Console.WriteLine(kantoorMieke.Adres.Huisnummer);
            
            mieke.Adres.Huisnummer = "99";

            //voorbeeld 2
            Console.WriteLine(kantoorMieke.Adres.Huisnummer);
        }
    }
}
