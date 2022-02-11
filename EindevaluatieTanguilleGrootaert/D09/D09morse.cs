using System;

namespace D09
{
    class D09morse
    {
        static void Main(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string uitgevoerdeCode = "";

            Console.Write("Indien u van morse naar letters wenst te vertalen geeft u 1 in, indien u van letters naar morse wenst te vertalen geeft u 2 in: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                while (true)
                {
                    Console.Write("Geef de morse in die u in tekst wenst te vertalen: ");
                    string zoekMorse = Console.ReadLine();

                    for (int i = 0; i < morse.Length; i++)
                    {
                        if (zoekMorse == morse[i])
                        {
                            uitgevoerdeCode += letters[i].ToString();
                            break;
                        }
                    }
                    Console.WriteLine($"{zoekMorse} stelt de letter {uitgevoerdeCode} voor. (Typ stop in om te stoppen)");
                }
            }
            else if (input == 2)
            {
                while (true)
                {
                    Console.Write("Geef de letters in die u in morse wenst te vertalen: ");
                    char zoekLetters = char.Parse(Console.ReadLine());

                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (zoekLetters == letters[i])
                        {
                            uitgevoerdeCode += morse[i].ToString();
                            break;
                        }
                    }
                    Console.WriteLine($"{zoekLetters} stelt de morsecode van {uitgevoerdeCode} voor. (Typ stop in om te stoppen)");
                }
            }
        }
    }
}
