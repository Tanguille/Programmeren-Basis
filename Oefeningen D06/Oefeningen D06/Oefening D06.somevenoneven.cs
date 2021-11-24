using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int even = 0;
            int oneven = 0;
            int evenSom = 0;
            int onevenSom = 0;

            do
            {
                Console.Write("Geef een getal (negatief om te stoppen): ");
                getal = int.Parse(Console.ReadLine());

                if (getal <= 0)
                {
                    Console.WriteLine(even + " even getallen");
                    Console.WriteLine(oneven + " oneven getallen");
                    Console.WriteLine("De som van de even getallen bedraagt " + evenSom);
                    Console.WriteLine("De som van de oneven getallen bedraagt " + onevenSom);
                }
                else if (getal % 2 ==0)
                {
                    even++;
                    evenSom += getal;
                }
                else
                {
                    oneven++;
                    onevenSom += getal;
                }
            } while (getal >= 0);  
                         
            
        }
        }
    }

    


