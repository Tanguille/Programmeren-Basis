using System;

namespace D10
{
    class D10toonvierkantparameters
    {
        static void Main(string[] args)
        {
            int i = 5;
            ToonVierkant(i);

            static void ToonVierkant(int zijde)
            {
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
