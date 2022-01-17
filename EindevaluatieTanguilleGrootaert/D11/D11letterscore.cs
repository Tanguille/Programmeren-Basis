using System;

namespace D11
{
    class D11letterscore
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw score in % : ");
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine($"In Amerika is dat een \"{GetLetterCodeForPercentage(score)}\".");
        }
        static char GetLetterCodeForPercentage(int score)
        {
            char letterScore = ' ';

            if (score > 82)
            {
                letterScore = 'A';
            }
            else if (score > 67)
            {
                letterScore = 'B';
            }
            else if (score > 52)
            {
                letterScore = 'C';
            }
            else if (score > 37)
            {
                letterScore = 'D';
            }
            else if (score > 22)
            {
                letterScore = 'E';
            }
            else
            {
                letterScore = 'F';
            }
            return letterScore;
        }
    }
}
