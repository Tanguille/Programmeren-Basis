using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel start over 3 seconden...");
            System.Threading.Thread.Sleep(3000);

            while (true)
            {
                Random rnd = new Random();
                int lichaamsdeel = rnd.Next(0, 3);
                if (lichaamsdeel == 0)
                {
                    Console.Write("Linkerhand op ");
                }
                else if (lichaamsdeel == 1)
                {
                    Console.Write("Rechterhand op ");
                }
                else if (lichaamsdeel == 2)
                {
                    Console.Write("Linkervoet op ");
                }
                else if (lichaamsdeel == 3)
                {
                    Console.Write("Rechtervoet op ");
                }

                Random rnd2 = new Random();
                int kleur = rnd.Next(0, 3);
                if (kleur == 0)
                {
                    Console.WriteLine("rood");
                }
                else if (kleur == 1)
                {
                    Console.WriteLine("groen");
                }
                else if (kleur == 2)
                {
                    Console.WriteLine("blauw");
                }
                else if (kleur == 3)
                {
                    Console.WriteLine("geel");
                }

                System.Threading.Thread.Sleep(7000);
            }
      
        }
        }                       
        }
    


