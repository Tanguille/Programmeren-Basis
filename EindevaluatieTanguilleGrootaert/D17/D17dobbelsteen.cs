using System;
using System.Collections.Generic;

namespace D17
{
    internal class D17dobbelsteen
    {
        static void Main(string[] args)
        {
            int aantal = 0;
            Random rnd = new Random();
            Dictionary<int, int> diceCount = new Dictionary<int, int>
            {
                { 1, 0}, { 2, 0}, { 3, 0}, { 4, 0}, { 5, 0}, { 6, 0}
            };

            for (int i = 0; i < 100; i++)
            {
                int randomNummer = rnd.Next(1, 7);
                aantal = diceCount[randomNummer];
                aantal++;
                diceCount[randomNummer] = aantal;
            }
            foreach (int key in diceCount.Keys)
            {
                aantal = diceCount[key];
                Console.WriteLine($"{key} komt {aantal} keer voor");
            }
        }
    }
}
