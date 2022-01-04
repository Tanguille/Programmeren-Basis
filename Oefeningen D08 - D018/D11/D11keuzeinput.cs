using System;

namespace D11
{
    internal class D11keuzeinput
    {
        static void Main()
        {
            string[] keuzes = { "Rood", "Groen", "Blauw" };
            int index = GetKeuze(keuzes);
            string kleur = keuzes[index];
            Console.WriteLine($"U koos {kleur}");
        }
        static int GetKeuze(string[] keuzes)
        {
            int index = -1;

            Console.Write("Geef uw keuze (" + String.Join("|", keuzes) +") : ");
            string input = Console.ReadLine();

            for (int i = 0; i < keuzes.Length; i++)
            {
                //Opgezocht online na veel proberen met nesten van loops en indexen.
                if (keuzes[i].Equals(input, StringComparison.CurrentCultureIgnoreCase))
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
