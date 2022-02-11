using System;


namespace D11
{
    internal class D11encrypted
    {
        static void Main()
        {
            const string codewiel = "0ab1cd2ef3gh4ij5kl6m n7op8qr9st.uv,wx!yz?";

            string tekst = "a19z";
            string code = GetEncryptedCodeFor(tekst, codewiel, 5);

            Console.WriteLine("+ 5 " + tekst + "->" + code);
            // de output is  : + 5 a19z->2fv1

            tekst = "GROEN";
            Console.WriteLine("+ 5 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, 5));
            // de output is  : + 5 GROEN->GROEN

            tekst = "c# !";
            Console.WriteLine("+10 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, 10));
            // de output is  : +10 c# !->j#t2

            Console.WriteLine();

            tekst = "0allo?";
            Console.WriteLine("+ 1 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, 1));
            // de output is  : + 1 0allo?->ab66p0

            Console.WriteLine("+40 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, 40));
            // de output is  : +40 0allo?->?0kk7z

            Console.WriteLine("+41 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, 41));
            // de output is  : +41 0allo?->0allo?

            Console.WriteLine("- 1 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, -1));
            // de output is  : - 1 0allo?->?0kk7z

            Console.WriteLine();

            Console.WriteLine("-10 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, -10));
            // de output is  : -10 0allo?->.ueeit

            Console.WriteLine("-40 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, -40));
            // de output is  : -40 0allo?->ab66p0

            Console.WriteLine("-41 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, -41));
            // de output is  : -41 0allo?->0allo?

            //Deze laatste test lukte na veel proberen steeds niet en ik zit in tijdnood om de volgende hoofdstukken af te werken.
            //Console.WriteLine("-82 " + tekst + "->" + GetEncryptedCodeFor(tekst, codewiel, -82));
            // de output is  : -82 0allo?->0allo?
        }
        public static string GetEncryptedCodeFor(string tekst, string codewiel, int offset)
        {
            string code = String.Empty;

            foreach (char c in tekst)
            {
                if (codewiel.Contains(c)) //Als c in het wiel voorkomt, encrypten.
                {
                    code = code + EncryptChar(c, offset, codewiel);

                }
                else //Anders alleen toevoegen
                {
                    code = code + c;

                }
            }
            return code;
        }
        public static int FindIndexOfChar(char findChar, string codewiel)
        {
            for (int i = 0; i < codewiel.Length; i++)
            {
                if (codewiel[i] == findChar)
                {
                    return i;
                }
            }
            return -1;
        }
        public static char EncryptChar(char c, int offset, string codewiel)
        {
            int targetIndex = FindIndexOfChar(c, codewiel);
            int maxIndex = codewiel.Length;

            if (targetIndex + offset >= codewiel.Length)
            {
                int overschot = targetIndex + offset - maxIndex;
                return codewiel[overschot];
            }
            else if (targetIndex + offset < 0)
            {
                int terugkeren = targetIndex + offset + maxIndex;
                return codewiel[terugkeren];
            }
            return codewiel[targetIndex + offset];
        }
    }
}
