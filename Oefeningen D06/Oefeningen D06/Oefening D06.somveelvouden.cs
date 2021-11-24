using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            Console.Write("Geef een getal: ");
            int laagGetal = int.Parse(Console.ReadLine());

            Console.Write("Geef een getal: ");
            int hoogGetal = int.Parse(Console.ReadLine());

            do
            {
                if (laagGetal % 3 ==0)
                {
                    som += laagGetal;
                }
                if (laagGetal % 5 == 0)
                {
                    som += laagGetal;
                }
                laagGetal++;

            } while (laagGetal < hoogGetal);
            Console.WriteLine(som);
        }
        }
    }

    


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            Console.Write("Geef een getal: ");
            int laagGetal = int.Parse(Console.ReadLine());

            Console.Write("Geef een getal: ");
            int hoogGetal = int.Parse(Console.ReadLine());

            for ( int i = laagGetal; laagGetal <= hoogGetal; laagGetal++)
            {
                if (laagGetal % 3 == 0 || laagGetal % 5 == 0)
                {
                    som += laagGetal;
                    Console.WriteLine(laagGetal);
                }              
            }           
            Console.WriteLine("De som van de tussenliggende 3-vouden en 5-vouden is " + som);
        }
        }
    }

    


