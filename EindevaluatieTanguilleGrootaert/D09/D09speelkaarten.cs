using System;

namespace D09
{
    class D09speelkaarten
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };

            string[] kaarten = new string[kleuren.Length * waarden.Length];
            int i = 0;

            foreach (string kleur in kleuren)
            {
                foreach (string waarde in waarden)
                {
                    kaarten[i] = kleur + " " + waarde;
                    Console.WriteLine(kaarten[i]);
                    i++;
                }
            }
        }
    }
}
