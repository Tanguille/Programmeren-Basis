using System;

namespace D10
{
    internal class D10faculteit
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal = int.Parse(Console.ReadLine());
            int faculteitGetal = GetFaculteit(getal);

            Console.WriteLine(getal + "! is " + faculteitGetal);
            static int GetFaculteit(int getal)
            {
                int som = 1;                
                for (int i = 2; i <= getal; i++)
                {                    
                    som = som * i;
                }
                return som;
            }
        }
    }
}
