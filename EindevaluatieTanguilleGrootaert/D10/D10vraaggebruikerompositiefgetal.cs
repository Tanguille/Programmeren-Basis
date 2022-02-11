using System;

namespace D10
{
    internal class D10vraaggebruikerompositiefgetal
    {
        static void Main(string[] args)
        {
            int breedte = VraagGebruikerOmPositiefGetal("Geef de breedte : ");
            int hoogte = VraagGebruikerOmPositiefGetal("Geef de hoogte : ");
            ToonRechthoek(breedte, hoogte);

            static int VraagGebruikerOmPositiefGetal(string vraag)
            {
                bool gelukt;
                int getal = 0;
                do
                {
                    Console.Write(vraag);
                    string getalAlsTekst = Console.ReadLine();
                    gelukt = int.TryParse(getalAlsTekst, out getal);
                } while (!gelukt || getal < 1);

                return getal;
            }

            static void ToonRechthoek(int breedte, int hoogte)
            {
                string horizontaal = "";

                for (int i = 0; i < breedte; i++)
                {
                    horizontaal += "*";
                }
                for (int i = 0; i < hoogte; i++)
                {
                    Console.WriteLine(horizontaal);
                }
            }
        }
    }
}
