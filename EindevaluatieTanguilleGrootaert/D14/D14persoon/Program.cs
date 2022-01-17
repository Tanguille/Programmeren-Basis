using System;

namespace D14.D14persoon
{
    class Program
    {
        static void Main(string[] args)
        {

            Persoon p1 = new Persoon();
            p1.SetNaam("Tanguille");
            p1.SetWoonplaats("Merelbeke");
            p1.SetGeboortedatum(new DateTime(1999, 9, 1));
            ToonPersoonsgegevens(p1);

            Persoon p2 = new Persoon();
            p2.SetNaam("Timo");
            p2.SetWoonplaats("Gentbrugge");
            p2.SetGeboortedatum(new DateTime(1999, 4, 22));
            ToonPersoonsgegevens(p2);

            p2.SetNaam("Timothy");
            p2.SetWoonplaats("Gent");
            p2.SetGeboortedatum(new DateTime(1999, 4, 23));
            ToonPersoonsgegevens(p2);
        }
        static void ToonPersoonsgegevens(Persoon p)
        {
            Console.WriteLine(p.GetNaam());
            Console.WriteLine(p.GetWoonplaats());
            Console.WriteLine(p.Leeftijd());
            Console.WriteLine(); //Overzichtelijker.
        }
    }
}
