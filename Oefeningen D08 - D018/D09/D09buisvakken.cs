using System;

namespace D09
{
    class D09buisvakken
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };
            bool onvoldoende = false;

            for (int i = 0; i < vakken.Length; i++)
            {
                if (scores[i] < 50)
                {
                    Console.WriteLine($"De student haalde een onvoldoende voor {vakken[i]}.");
                }
            }
        }
    }
}

