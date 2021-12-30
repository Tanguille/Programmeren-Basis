using System;


namespace D09
{
    class D09dierenwissen
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };
            string teVerwijderen = "";

            while (true)
            {
                for (int i = 0; i < boerderijDieren.Length; i++)           
                {
                    int index = Array.IndexOf(boerderijDieren, teVerwijderen);

                    if (index != -1)
                    {                       
                        boerderijDieren[index] = null;
                    }

                    if (boerderijDieren[i] == null)
                    {
                        Console.Write("GEWIST ");
                    }
                    else
                    {
                        Console.Write(boerderijDieren[i] + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("Welk van deze dieren wenst u uit de lijst te verwijderen?: ");
                teVerwijderen = Console.ReadLine();
            }
        }
    }
}
