﻿using System;

namespace D14.D14rechthoek
{
    internal class Program
    {
        static void Main()
        {
            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.SetHoogte(4.1);
            rechthoek1.SetBreedte(8);

            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek2.SetHoogte(5);
            rechthoek2.SetBreedte(10.2);

            PrintRechthoek(rechthoek1);
            PrintRechthoek(rechthoek2);
        }
        static void PrintRechthoek(Rechthoek r)
        {
            Console.WriteLine($"Rechthoek met hoogte {r.GetHoogte()}, breedte {r.GetBreedte()} en oppervlakte {r.Oppervlakte()}.");
        }
    }
}

