﻿using System;

namespace D11
{
    internal class D11filter
    {
        static void Main()
        {
            // Het array met waarden dat we als voorbeeld gebruiken
            int[] meetwaarden = { 3, 6, 10, -1, -23, 0, -6, 7, 10, -15, -4, 10 };

            // Een variabele voor de return value van een Filter method oproep
            int[] gefilterd;

            // Filter alle meetwaarden die tussen -4 en 7 liggen (grenzen inclusief)
            gefilterd = Filter(meetwaarden, -4, 7);


            Console.WriteLine(String.Join(",", gefilterd));
            // De output is : 3,6,-1,0,7,-4
            // Let erop dat de volgorde van de waarden in de output gelijk is aan
            // hun onderlinge volgorde in het 'meetwaarden' array!

            // Filter alle meetwaarden die tussen 10 en 10 liggen (grenzen inclusief)
            // (anders gezegd, hou enkel de tienen over).
            gefilterd = Filter(meetwaarden, 10, 10);


            Console.WriteLine(String.Join(",", gefilterd));
            // De output is : 10,10,10
            // Let erop dat de waarde 10 drie keer voorkomt omdat ze ook
            // drie keer voorkwam in het 'meetwaarden' array.

            // Filter alle meetwaarden die tussen 100 en 200 liggen (grenzen inclusief)
            gefilterd = Filter(meetwaarden, 100, 200);


            Console.WriteLine(String.Join(",", gefilterd));
            // De output is :
            // Let erop dat de output een lege regel is, er zijn immers geen
            // waarden tussen 100 en 200 in 'meetwaarden'. De lengte van
            // array 'gefilterd' is nu dus gelijk aan 0!}
        } 
        static int[] Filter(int[] meetwaarden, int min, int max)
        {
            //Na lang opzoeken heb ik de FindAll method gevonden op stackoverflow waardoor de filtering werkt. Een forloop die de filter array vult lukte voor een onverklaarbare reden niet.
            int[] gefilterd = Array.FindAll(meetwaarden, getal => getal >= min && getal <= max);
                         
            return gefilterd;
        }
    }
}
