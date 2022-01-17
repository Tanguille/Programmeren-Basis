using System;
using System.Collections.Generic;

namespace D17
{
    internal class D17morse
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> letterNaarMorse = new Dictionary<char, string>
            {
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}
            };

            while (true)
            {
                Console.Write("Geef de letters in die u in morse wenst te vertalen: ");
                char zoekLetter = char.Parse(Console.ReadLine());

                if (letterNaarMorse.ContainsKey(zoekLetter))
                {
                    Console.WriteLine($"{zoekLetter} stelt de morsecode van {letterNaarMorse[zoekLetter]} voor.");
                }
                else
                {
                    Console.WriteLine("Geen geldige letter.");
                }
            }

        }
    }
}
