using System;

namespace ConsoleApp1
{
    class tussenaccolades
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            int indexLinks = tekst.IndexOf("{");
            int indexRechts = tekst.IndexOf("}");

            if (indexLinks != -1 && indexRechts != -1 && indexLinks < indexRechts)
            {
                int lengteTekstErtussen = indexRechts - indexLinks - 1;
                int indexTekstErtussen = indexLinks + 1;
                string tekstErtussen = tekst.Substring(indexLinks + 1, lengteTekstErtussen);
                Console.WriteLine("gevonden: " + tekstErtussen);
            }
            else
            {
                Console.WriteLine("Niets gevonden");
            }
        

            
                    
               
           
        }
    }
}

