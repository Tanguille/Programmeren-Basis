﻿using System;

namespace D08
{
    class D08arrayopvullen
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[9];

            for (int i = 0; i < getallen.Length; i++)
            {
                 getallen[i] = 101 + i;   
            }

            for (int index = 0; index < getallen.Length; index++)
            {
                Console.Write(getallen[index] + " ");
            }
            
        }
    }
}