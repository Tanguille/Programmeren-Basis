using System;

namespace D14.D14selecteerwinnaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon[] vrienden = new Persoon[5] { new Persoon(), new Persoon(), new Persoon(), new Persoon(), new Persoon() } ;;
            vrienden[0].SetNaam("Kwin");
            vrienden[1].SetNaam("Senne");
            vrienden[2].SetNaam("Reinout");
            vrienden[3].SetNaam("Thibault");
            vrienden[4].SetNaam("Wout");

            Console.WriteLine($"Proficiat {SelecteerWinnaar(vrienden).GetNaam()}, je hebt gewonnen!");
        }
        static Persoon SelecteerWinnaar(Persoon[] deelnemers)
        {
            Random rnd = new Random();
            return deelnemers[rnd.Next(deelnemers.Length)];
        }
    }
}
