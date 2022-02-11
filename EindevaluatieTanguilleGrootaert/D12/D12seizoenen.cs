using System;

namespace D12
{
    internal class D12seizoenen
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");
            DateTime dateTime;
            bool gelukt;
            do
            {
                Console.Write("Geef een datum: ");
                gelukt = DateTime.TryParseExact(Console.ReadLine(), "dd/MM", nlBe, System.Globalization.DateTimeStyles.None, out dateTime);
            } while (!gelukt);

            DateTime startLente = new DateTime(DateTime.Now.Year, 03, 01);
            DateTime startZomer = new DateTime(DateTime.Now.Year, 06, 01);
            DateTime startHerfst = new DateTime(DateTime.Now.Year, 09, 01);
            DateTime startWinter = new DateTime(DateTime.Now.Year, 12, 01);

            if (dateTime >= startWinter || dateTime < startLente)
            {
                Console.WriteLine("Winter");
            }
            else if (dateTime >= startLente && dateTime < startZomer)
            {
                Console.WriteLine("Lente");
            }
            else if (dateTime >= startZomer && dateTime < startHerfst)
            {
                Console.WriteLine("Zomer");
            }
            else if (dateTime >= startHerfst && dateTime < startWinter)
            {
                Console.WriteLine("Herfst");
            }
        }
    }
}
