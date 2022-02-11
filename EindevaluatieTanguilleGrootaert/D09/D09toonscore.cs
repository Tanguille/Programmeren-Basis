using System;

namespace D09
{
    class D09toonscore
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };
            int index = -1;

            Console.Write("Van welk vak wenst u de score te kennen?: ");
            string input = Console.ReadLine().ToLower();

            for (int i = 0; i < vakken.Length; i++)
            {
                if (input == vakken[i].ToLower())
                {
                    index = i;
                    Console.WriteLine($"Op het vak {input} werd {scores[i]} gescoord.");
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Sorry, dit vak staat niet in de lijst.");
            }

        }
    }
}
