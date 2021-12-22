using System;

namespace D08
{
    class D08twister
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel start over 3 seconden...");
            System.Threading.Thread.Sleep(3000);

            string[] kleuren = { "rood", "groen", "blauw", "geel" };
            string[] lichaamsdelen = { "linkerhand", "rechterhand", "linkervoet", "rechtervoet" };

            while (true)
            {
                Random rnd = new Random();
                int index1 = rnd.Next(0, 4);
                int index2 = rnd.Next(0, 4);    

                Console.WriteLine(lichaamsdelen[index1] + " op " + kleuren[index2]);

                System.Threading.Thread.Sleep(7000);
            }

        }
    }
}



