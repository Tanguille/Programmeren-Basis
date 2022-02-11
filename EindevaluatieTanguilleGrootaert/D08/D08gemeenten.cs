using System;

namespace D08
{
    class D08gemeenten
    {
        static void Main(string[] args)
        {
            string[] gemeenten = new string[8];

            for (int index = 0; index < 8; index++)
            {
                gemeenten[0] = "Brussel";
                gemeenten[1] = "1000";
                gemeenten[2] = "Antwerpen";
                gemeenten[3] = "2000";
                gemeenten[4] = "Brugge";
                gemeenten[5] = "8000";
                gemeenten[6] = "Gent";
                gemeenten[7] = "9000";

                if (index % 2 != 0)
                {
                    Console.WriteLine(gemeenten[index]);
                }
            }
        }
    }
}



