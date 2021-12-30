using System;

namespace D09
{
    class D09censuur
    {
        static void Main(string[] args)
        {
            string[] scheldwoorden = { "kut", "loser", "mietje", "mongool", "moffenhoer", "hoerenzoon", "teringlijer", "trut", "schijthoofd", "zwijn" };

            Console.Write("Schrijf hier uw tekst: ");
            string input = Console.ReadLine();

            foreach (string woord in scheldwoorden)
            {
                if (input.Contains(woord))
                {
                    input = input.Replace(woord, new('*', woord.Length));
                }
            }
            Console.Write(input);
        }
    }
}
