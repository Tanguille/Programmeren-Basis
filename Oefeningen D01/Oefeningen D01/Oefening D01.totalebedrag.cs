using System;

namespace Oefening_D01
{
    class D01totalebedrag
    {
        static void Main(string[] args)
        {
            int biljettenVan10Euro = 7;
            int biljettenVan5Euro = 6;
            int muntstukkenVan2Euro = 5;
            int muntstukkenVan1Euro = 4;
            int muntstukkenVan50Cent = 3;

            double totaalbedrag = biljettenVan10Euro * 10 + biljettenVan5Euro * 5 + muntstukkenVan2Euro * 2 + muntstukkenVan1Euro + muntstukkenVan50Cent * 1/2 ;
            Console.WriteLine(totaalbedrag);


        }
    }
}
