using System;

namespace D15.D15afstandtussenpunten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punt p1 = new Punt(4.0, 6.0);
            Punt p2 = new Punt(7.0, 2.0);
            
            Console.WriteLine(Punt.GetAfstandTussen(p1, p2));
        }   
    }
}
