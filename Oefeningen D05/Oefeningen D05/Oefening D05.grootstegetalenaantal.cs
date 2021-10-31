using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int grootsteGetal = 0;
            int teller = 0;
            int aantal = 0;
            do
            {
                Console.Write("Geef een getal: ");
                string getalAlsTekst = Console.ReadLine();
                getal = int.Parse(getalAlsTekst);
                teller++;
                if (teller == 1 || getal > grootsteGetal)
                {
                    grootsteGetal = getal;
                    aantal++;
                }
                
            } while (getal != -1);
           
            
            Console.Write($"Het grootste getal is {grootsteGetal}, dit is {aantal} keer voorgekomen.");

        }
    }
}
    
