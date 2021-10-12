using System;

namespace Oefening_D01
{
    class D01waardesomwisselen
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;
            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
