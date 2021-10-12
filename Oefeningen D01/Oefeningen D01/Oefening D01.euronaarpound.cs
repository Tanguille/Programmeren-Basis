using System;

namespace Oefening_D01
{
    class D01euronaarpound
    {
        static void Main(string[] args)
        {
            decimal euroBedrag = 105.4m;
            decimal poundBedrag = euroBedrag * 0.88m;
            Console.Write(euroBedrag);
            Console.Write("EUR = ");
            Console.Write(poundBedrag);
            Console.Write("GPB");


        }
    }
}
