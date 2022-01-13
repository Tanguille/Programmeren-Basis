using System;


namespace D15.D15encrypter
{
    internal class Encrypter
    {
        private const string _codewiel = "0ab1cd2ef3gh4ij5kl6m n7op8qr9st.uv,wx!yz?";
        
        private int _offset;        
           
        public Encrypter(int offset)
        {
            _offset = offset;
        }

        public string GetCodeFor(string tekst)
        {
            string code = String.Empty;

            foreach (char c in tekst)
            {
                if (_codewiel.Contains(c)) //Als c in het wiel voorkomt, encrypten.
                {
                    code = code + EncryptChar(c, _offset, _codewiel);

                }
                else //Anders alleen toevoegen
                {
                    code = code + c;

                }
            }
            return code;
        }
        public int FindIndexOfChar(char findChar, string codewiel)
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
        public char EncryptChar(char c, int offset, string codewiel)
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
