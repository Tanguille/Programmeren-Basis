using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16socialmediafilter
    {
        static void Main()
        {
            // Maak een lijst van woorden die misschien gecensureerd moeten worden
            List<string> words = new List<string> { "oranje", "trump", "haar", "Trump", "bedrog", "verkiezingen", "winnaar" };

            // Maak een set van 'stoute woordjes' die we willen censureren
            HashSet<string> naughtyWords = new HashSet<string> { "Trump", "fraude", "verkiezingen" };

            // Toon eerste eens alle woorden
            Console.WriteLine(String.Join(",", words));

            // Censureer waar nodig
            List<string> gecensureerd = SocialMediaFilter(words, naughtyWords);

            // Toon de woorden opnieuw, dit keer geschikt voor gevoelige zieltjes
            Console.WriteLine(String.Join(",", gecensureerd));
        }
        static List<string> SocialMediaFilter(List<string> words, HashSet<string> naughtyWords)
        {
            List<string> gecensureerd = new List<string>();
            foreach (string word in words)
            {
                if (naughtyWords.Contains(word))
                {
                    string censuur = new string('*', word.Length);
                    gecensureerd.Add(censuur);
                }
                else
                {
                    gecensureerd.Add(word);
                }
            }
            return gecensureerd;
        }
    }
}
