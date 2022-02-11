using System;

namespace D09
{
    class D09dagnummernaarmaand
    {
        static void Main(string[] args)
        {
            int[] aantalDagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] maandNamen = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };
            int som = 0;

            Console.Write("Geef een dagnummer (1-365): ");
            int dagnummer = int.Parse(Console.ReadLine());

            for (int i = 0; i < aantalDagen.Length; i++)
            {
                som += aantalDagen[i];
                int somTotaal = dagnummer - som;
                //Console.WriteLine(totaalSom);

                if (somTotaal <= aantalDagen[i])
                {
                    Console.WriteLine($"Deze dag valt in {maandNamen[i]}");
                    break;
                }
            }
        }
    }
}
