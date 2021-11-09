using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maanden;
            Console.Write("Aantal maanden groei?: ");
            bool invoerOk = int.TryParse(Console.ReadLine(), out maanden);

            if (invoerOk && maanden >= 1)
            {
                int fibo1 = 0;
                int fibo2 = 1;
                int fibo3;

                int maandTeller = 1;
                do
                {
                    fibo3 = fibo1 + fibo2;

                    fibo1 = fibo2;
                    fibo2 = fibo3;

                    maandTeller = maandTeller + 1;

                } while (maandTeller < maanden);
                
            

             Console.Write($"Aantal knooppunten: {fibo3}");
            }
        }
            
            
        }
    }


