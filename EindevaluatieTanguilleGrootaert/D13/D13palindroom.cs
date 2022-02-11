using System;

namespace D13
{
    internal class D13palindroom
    {
        static void Main()
        {
            Console.WriteLine("Geef een tekst : ");
            string tekst = Console.ReadLine();

            Console.WriteLine(IsPalindroom(tekst));
        }

        static bool IsPalindroom(string tekst)
        {
            string reverse = ReverseText(tekst);
            if (tekst == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ReverseText(string tekst)
        {
            //breakpunt op lijn 32 toont me dat het result een lege string blijft. 
            string result = "";
            foreach (char c in tekst)
            {
                //Er miste een + voor het = waardoor de string niet aangevuld werd maar leeg bleef
                result += c.ToString();
            }
            return result;
        }
        //Nu dat dit aangepast is returned het programma true bij input "kajak".
    }
}
