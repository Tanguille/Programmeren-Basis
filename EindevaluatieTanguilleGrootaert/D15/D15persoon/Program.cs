using System;

namespace D15.D15persoon
{
    class Program
    {
        static void Main(string[] args)
        {

            Persoon p1 = new Persoon();
            p1.Naam = "Tanguille";
            p1.Woonplaats = "Merelbeke";
            p1.Geboortedatum = new DateTime(1999, 9, 1);
            ToonPersoonsgegevens(p1);

            Persoon p2 = new Persoon();
            p2.Naam = "Timo";
            p2.Woonplaats = "Gentbrugge";
            p2.Geboortedatum = new DateTime(1999, 4, 22);
            ToonPersoonsgegevens(p2);

            p2.Naam = "Timothy";
            p2.Woonplaats = "Gent";
            p2.Geboortedatum = new DateTime(1999, 4, 23);
            ToonPersoonsgegevens(p2);
        }
        static void ToonPersoonsgegevens(Persoon p)
        {
            Console.WriteLine(p.Naam);
            Console.WriteLine(p.Woonplaats);
            Console.WriteLine(p.Leeftijd());
            Console.WriteLine(); //Overzichtelijker.
        }
    }
}
