using System;
using System.Linq;

namespace D13
{
    internal class D13frequentie
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[10];
            bool geldig;
            int getal;

            for (int i = 0; i < 10;)
            {
                Console.Write("Getal " + (i+1) + "? ");
                geldig = int.TryParse(Console.ReadLine(), out getal);

                getallen[i] = getal;
                if (geldig)
                {
                    i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Som: " + getallen.Sum());
            Console.WriteLine("Gemiddelde: " + getallen.Average());

            //Na lang zoeken ben ik via google op deze oplossing gekomen. 
            Console.WriteLine("Frequenties: ");
            var frequentie = getallen.GroupBy(r => r).Select(grp => new { Value = grp.Key, Count = grp.Count() });
            foreach (var item in frequentie)
            {                
                Console.WriteLine("{0} komt {1} keer voor", item.Value, item.Count);              
            }
        }
    }
}
