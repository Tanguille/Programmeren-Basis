using System;

namespace D10
{
    class D10toonvierkant
    {
        static void Main(string[] args)
        {
            ToonVierkant();

            static void ToonVierkant()
            {
                int zijde = 5;
                int hoogteTeller = 0;
                do
                {
                    int breedteTeller = 0;
                    do
                    {
                        Console.Write("*");
                        breedteTeller++;
                    } while (breedteTeller < zijde);
                    Console.WriteLine();
                    hoogteTeller++;
                } while (hoogteTeller < zijde);
            }
        }
    }
}
