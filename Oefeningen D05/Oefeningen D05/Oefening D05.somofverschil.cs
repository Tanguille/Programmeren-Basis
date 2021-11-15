using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultaat = int.Parse(Console.ReadLine());
            string wiskundeTeken = Console.ReadLine();

            while (wiskundeTeken != "=")
            {
                int getal = int.Parse(Console.ReadLine());                
                if (wiskundeTeken == "+")
                {
                    resultaat = resultaat + getal;
                }
                else if (wiskundeTeken == "-")
                {
                    resultaat = resultaat - getal;
                }
                wiskundeTeken = Console.ReadLine();
            }
            Console.Write(resultaat);
        }                       
        }
    }


