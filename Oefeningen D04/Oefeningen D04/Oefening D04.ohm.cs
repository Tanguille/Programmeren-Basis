using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Wat wenst u te berekenen? (Spanning, Weerstand of Stroomsterkte): ");
           string GevraagdeWaarde = Console.ReadLine();

            if (GevraagdeWaarde == "spanning")
            {
                Console.Write("Wat is de stroomsterkte? ");
                int stroomsterkte = int.Parse(Console.ReadLine());

                Console.Write("Wat is de weerstand? ");
                int weerstand = int.Parse(Console.ReadLine());

                int spanning = stroomsterkte * weerstand;
                Console.WriteLine(spanning + " V");
            }
            else if (GevraagdeWaarde == "weerstand")
            {
                Console.Write("Wat is de spanning? ");
                int spanning = int.Parse(Console.ReadLine());

                Console.Write("Wat is de stroomsterkte? ");
                int stroomsterkte = int.Parse(Console.ReadLine());

                int weerstand = spanning / stroomsterkte;
                Console.WriteLine(weerstand + " Ohm");
            }
            else if (GevraagdeWaarde == "stroomsterkte")
            {
                Console.Write("Wat is de spanning? ");
                int spanning = int.Parse(Console.ReadLine());

                Console.Write("Wat is de weerstand? ");
                int weerstand = int.Parse(Console.ReadLine());

                int stroomsterkte = spanning / weerstand;
                Console.WriteLine(stroomsterkte + " A");
            }

         
            
            
        }
    }
}
    
