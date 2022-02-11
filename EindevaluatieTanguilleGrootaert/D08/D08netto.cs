using System;

namespace D08
{
    class D08netto
    {
        static void Main(string[] args)
        {
            double[] kortingen = { 10d, 50d, 19.4d };
            double brutoBedrag = 1000d;
            
            double nettoBedrag = brutoBedrag;
            foreach (double i in kortingen)
            {
                nettoBedrag -= i;
            }            
        }
    }
}




