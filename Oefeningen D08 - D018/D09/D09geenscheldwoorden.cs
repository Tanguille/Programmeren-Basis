using System;
using System.Linq;

namespace D09
{
    class D09geenscheldwoorden
    {
        static void Main(string[] args)
        {
            string[] scheldwoorden = { "kut", "loser", "mietje", "mongool", "moffenhoer", "hoerenzoon", "teringlijer", "trut", "schijthoofd", "zwijn" };
            
            Console.Write("Schrijf hier uw tekst: ");
            string input = Console.ReadLine().ToLower();

            if (scheldwoorden.Contains(input))
            {
                Console.WriteLine("Deze text is ongeldig.");
            }
            else
            {
                Console.WriteLine("Uw tekst werd aanvaard.");
            }
        }
    }
}
