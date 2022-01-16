using System;

namespace Rekeningkantoor
{
    internal class D15rekeningkantoor
    {
        static void Main(string[] args)
        {
            //zie folder "Rekeningkantoor" voor klasses

            Persoon jan = new Persoon("Jan", "Janssens",  new Adres("Koekoekstraat", "70", "9090", "Melle"));
            Persoon mieke = new Persoon("Mieke", "Mickelsen", new Adres("Kerkstraat", "12", "8000", "Brugge"));

            Kantoor kMieke = new Kantoor(mieke, mieke.Adres);

            Rekening rJan = new Rekening("BE11 2222 3333 4444", 120.0, kMieke, jan);

            //voorbeeld 1
            Console.WriteLine($"{jan.Voornaam} {jan.Familienaam}, {jan.Adres.Straat} {jan.Adres.Huisnummer}, {jan.Adres.Postcode} {jan.Adres.Gemeente}");

            //Voorbeeld 2
            Console.WriteLine($"{jan.Voornaam} heeft een rekening met nummer {rJan.Nummer} met daarop {rJan.Saldo}Eur");

            //Voorbeeld 3
            Console.WriteLine($"Deze rekening is bij het kantoor van {mieke.Voornaam} {mieke.Familienaam}, {kMieke.Adres.Straat} {kMieke.Adres.Huisnummer}, {kMieke.Adres.Postcode} {kMieke.Adres.Gemeente}");

            //Voorbeeld 4
            Console.WriteLine(mieke.Voornaam + " woont in haar kantoor.");
        }
    }
}
