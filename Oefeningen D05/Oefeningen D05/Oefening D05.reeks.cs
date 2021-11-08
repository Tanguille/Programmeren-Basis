using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1?: ");
            int getal1;
            bool invoerOk;
            do
            {
                string getalAlsTekst = Console.ReadLine();
                invoerOk = int.TryParse(getalAlsTekst, out getal1);
                if (!invoerOk)
                {
                    Console.Write("Gelieve een geheel getal in te voeren, getal 1?: ");
                }
            } while (!invoerOk);

            Console.Write("Getal 2?: ");
            int getal2;
            do
            {
                string getalAlsTekst = Console.ReadLine();
                invoerOk = int.TryParse(getalAlsTekst, out getal2);
                if (!invoerOk)
                {
                    Console.Write("Gelieve een geheel getal in te voeren, getal 2?: ");
                }
            } while (!invoerOk);
            Console.Write("Reeks van klein naar groot: ");
            int som1 = getal1 - getal2;
            int som2 = getal2 - getal1;
            if (som1 > som2)
            {             
                do
                {
                    getal2++;
                    Console.Write(getal2 - 1 + " ");
                } while (getal1 >= getal2);
            }
            else
            {
                do
                {
                    getal1++;
                    Console.Write(getal1 - 1 + " ");
                } while (getal2 >= getal1);
            }
            
        }
    }
}

