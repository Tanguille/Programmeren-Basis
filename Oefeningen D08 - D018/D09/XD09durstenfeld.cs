using System;
namespace D09
{
    class D09durstenfeld
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };
            string[] kaarten = new string[kleuren.Length * waarden.Length];

            int i = 0;
            Random rnd = new();

            foreach (string kleur in kleuren)
            {
                foreach (string waarde in waarden)
                {
                    kaarten[i] = kleur + " " + waarde;
                    i++;
                }
            }

            for (int ongeschud = kaarten.Length - 1; ongeschud >= 1; ongeschud--)
            {
                int geschud = rnd.Next(ongeschud + 1);
                string tijdelijk = kaarten[ongeschud];
                kaarten[ongeschud] = kaarten[geschud];
                kaarten[geschud] = tijdelijk;
            }

            foreach (string kaart in kaarten)
            {
                Console.WriteLine(kaart);
            }
           
        }
    }
}

