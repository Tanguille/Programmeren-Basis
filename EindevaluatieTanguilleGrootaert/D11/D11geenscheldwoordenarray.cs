using System;
using System.Linq;

namespace D11
{
    class D11geenscheldwoordenarray
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            bool isOk = IsAanvaardbaar(tekst);

            if (isOk)
            {
                Console.WriteLine("Tekst is aanvaardbaar");
            }
            else
            {
                Console.WriteLine("Tekst is niet aanvaardbaar");
            }
        }
        static bool IsAanvaardbaar(string tekst)
        {
            string[] scheldwoorden = { "kut", "loser", "mietje", "mongool", "moffenhoer", "hoerenzoon", "teringlijer", "trut", "schijthoofd", "zwijn" };
            bool isOk = false;

            if (scheldwoorden.Contains(tekst))
            {
                isOk = false;
            }            
            return isOk;
        }
    }
}

