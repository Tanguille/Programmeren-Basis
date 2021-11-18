using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Geef een dagnummer: ");
                string dagnummer = Console.ReadLine();

                if (dagnummer == "1")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is maandag.");
                }
                else if (dagnummer == "2")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is dinsdag.");
                }
                else if (dagnummer == "3")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is woensdag.");
                } 
                else if (dagnummer == "4")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is donderdag.");
                }
                else if (dagnummer == "5")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is vrijdag.");
                }
                else if (dagnummer == "6")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is zaterdag.");
                }
                else if (dagnummer == "7")
                {
                    Console.WriteLine($"Dagnummer {dagnummer} is zondag.");
                }
                else if (true)
                {
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
        }
        }                       
        }
    


