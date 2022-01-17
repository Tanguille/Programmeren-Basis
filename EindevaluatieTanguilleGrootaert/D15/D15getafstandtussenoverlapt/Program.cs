﻿using System;

namespace D15.D15getafstandtussenoverlapt
{
    class Program
    {
        static void Main()
        {
			Punt p1 = new Punt(4, 6);
			Punt p2 = new Punt(7, 2);

			double afstand = p1.GetAfstandTussen(p2);
			Console.WriteLine(afstand);                  // moet 5 zijn

			Cirkel c1 = new Cirkel(10, 20, 5);
			Cirkel c2 = new Cirkel(8, 12, 10);
			Cirkel c3 = new Cirkel(100, 200, 3);

			Console.WriteLine(c1.Overlapt(c2));  // moet true opleveren
			Console.WriteLine(c2.Overlapt(c3));  // moet false opleveren
		}
    }
}
