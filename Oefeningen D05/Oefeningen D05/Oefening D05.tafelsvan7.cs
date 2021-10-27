using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 7;
            int vermeningvuldigaar = 1;
            
            do
            {
                int oplossing = getal * vermeningvuldigaar;
              Console.WriteLine($"{vermeningvuldigaar} X {getal} = {oplossing}");
                vermeningvuldigaar = vermeningvuldigaar + 1;
            } while (vermeningvuldigaar <=10 );



        }
    }
}
    
