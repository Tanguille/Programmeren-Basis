using System;

namespace Oefeningen_D02
{
    class D02som
    {
        static void Main(string[] args)
        {
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
            bool hetRegent = (regen == "ja");



            if (zon.ToLower().Trim() == "ja")
            {
                if (regen.ToLower().Trim() == "ja")


                    Console.WriteLine("Regenboog.");

                else if (zon.ToLower().Trim() == "nee")
                {
                    if (regen.ToLower().Trim() == "nee")


                        Console.WriteLine("Slecht weer.");

                    else if (zon.ToLower().Trim() == "ja")
                    {
                        if (regen.ToLower().Trim() == "nee")

                            Console.WriteLine("Mooi weer.");
                    }

                    else if (zon.ToLower().Trim() == "nee")
                    {
                        if (regen.ToLower().Trim() == "nee")


                            Console.WriteLine("Saaie dag");
                    }
                }
            }

        }
    }
}
