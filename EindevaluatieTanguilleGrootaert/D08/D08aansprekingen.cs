using System;

namespace D08
{
    class D08aansprekingen
    {
        static void Main(string[] args)
        {
            string[] aansprekingen = { "Jan", "Piet", "Pol" };

            foreach (string aanspreking in aansprekingen)
            {
                Console.WriteLine("Dag " + aanspreking);
            }
        }
    }
}