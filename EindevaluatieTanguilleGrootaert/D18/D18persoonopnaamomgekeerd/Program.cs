using System;
using System.Collections.Generic;
using System.Linq;

namespace D18.D18persoonopnaamomgekeerd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zie "Persoon.cs" in de folder van dit deel voor de persoonklasse.
            List<Persoon> personen = new List<Persoon>();
            Persoon p1 = new Persoon("Jan", 23);
            Persoon p2 = new Persoon("Miet", 45);
            Persoon p3 = new Persoon("Joris", 34);
            Persoon p4 = new Persoon("Corneel", 12);
            Persoon p5 = new Persoon("Phara", 34);

            personen.Add(p1);
            personen.Add(p2);
            personen.Add(p3);
            personen.Add(p4);
            personen.Add(p5);

            PrintPersonenMetTitel("ongesorteerd", personen);

            List<Persoon> sortedListAge = personen.OrderBy(o => o.Leeftijd).ToList();

            Console.WriteLine();
            PrintPersonenMetTitel("gesorteerd op leeftijd", sortedListAge);
                        
            Console.WriteLine();
            PrintPersonenMetTitel("gesorteerd op naam", PersoonNaamComparer(personen));
        }
        static void PrintPersonenMetTitel(string titel, List<Persoon> personen)
        {
            Console.WriteLine($"--- {titel} ---");
            foreach (Persoon p in personen)
            {
                Console.WriteLine(p.Naam + ", " + p.Leeftijd + " jaar");
            }
        }
        static List<Persoon> PersoonNaamComparer(List<Persoon> personen)
        {
            List<Persoon> sortedListName = personen.OrderBy(o => o.Naam).ToList();
            sortedListName.Reverse();
            return sortedListName;
        }
    }
}
