﻿using System;

namespace D11
{
    internal class D11clamped
    {
        static void Main()
        {
            Console.WriteLine("Voorbeeld GetClamped met min=3 en max=6");
            for (int i = 1; i <= 8; i++)
            {
                int clamped = GetClamped(3, i, 6);
                Console.WriteLine($"voor {i} geeft dit {clamped}");
            }
        }
        static int GetClamped(int min, int i, int max)
        {
            int clamp = i;

            if (min > i)
            {
                clamp = min;
            }
            if (max < i)
            {
                clamp = max;
            }
            return clamp;   
        }
    }
}
