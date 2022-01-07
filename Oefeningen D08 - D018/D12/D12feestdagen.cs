using System;

namespace D12
{
    internal class D12feestdagen
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");

            string[] namenFeestdagen = { "Nieuwjaar", "Paasmaandag", "Dag van de arbeid", "O.H. Hemelvaart", "Pinkstermaandag", "Nationale feestdag", "O.L.V. hemelvaart", "Allerheiligen", "Wapenstilstand", "Kerstmis" };
            string[] feestdagen = { "1/01", "18/04", "1/05", "26/05", "6/06", "21/07", "15/08", "1/11", "11/11", "25/12" };

            DateTime dateTime;
            bool gelukt;
            bool feestdag = false;

            do
            {
                Console.Write("Geef een datum: ");
                gelukt = DateTime.TryParseExact(Console.ReadLine(), "dd/MM", nlBe, System.Globalization.DateTimeStyles.None, out dateTime);
                
                if (!gelukt)
                {
                    Console.WriteLine("Ongeldige Datum.");
                }
            } while (!gelukt);

            for (int i = 0; i < feestdagen.Length; i++)
            {
                if (feestdagen[i] == dateTime.ToShortDateString().Substring(0, 4))
                {
                    Console.WriteLine($"Dat is \"" + namenFeestdagen[i] + "\"");
                    feestdag = true;
                    break;
                }
            }
            if (!feestdag)
            {
                Console.WriteLine("Dit is geen feestdag.");               
            }
        }
    }
}
