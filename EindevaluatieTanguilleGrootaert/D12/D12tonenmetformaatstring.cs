using System;

namespace D12
{
    internal class D12tonenmetformaatstring
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            string dagMaandJaar = dateTime.ToString("dd/MM/yyyy");
            string uurMinuut = dateTime.ToString("HH:mm");

            Console.WriteLine("De datum van vandaag is " + dagMaandJaar + " en het is nu " + uurMinuut + ".");
        }
    }
}
