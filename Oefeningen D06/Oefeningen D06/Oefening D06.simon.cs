using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string oplossingspoging;
            string code = "";      

            do
            {
                int nieuweGetal = rnd.Next(1, 5);
                code += nieuweGetal;

                Console.Clear();
                Console.WriteLine($"U heeft 2 seconden om deze code te onthouden: {code}");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Geef de code: ");
                oplossingspoging = Console.ReadLine();

            } while (oplossingspoging != code);          
        }
        }                       
        }
    


