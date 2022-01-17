﻿using System;

namespace D15.D15cirkelpunt
{
    class Program
    {
        static void Main()
        {
            Cirkel c = new Cirkel(10, 20, 5);   // x, y en straal
            Punt p1 = new Punt(13, 25);         // x en y
            Punt p2 = new Punt(8, 16);          // x en y

            Console.WriteLine(c.Bevat(p1));     // toont false
            Console.WriteLine(c.Bevat(p2));     // toont true

            c.VerplaatsNaar(11, 27);            // x en y

            Console.WriteLine(c.Middelpunt.X);  // toont 11
            Console.WriteLine(c.Middelpunt.Y);  // toont 27

            Console.WriteLine(c.Bevat(p1));     // toont true
            Console.WriteLine(c.Bevat(p2));     // toont false
        }
    }
}
