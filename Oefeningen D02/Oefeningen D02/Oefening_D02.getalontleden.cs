using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een geheel getal van 0-1000: ");
            string geheelGetalalstekst = Console.ReadLine();
            int geheelGetal = int.Parse(geheelGetalalstekst);

            int rest = geheelGetal;
            int honderdtallen = rest / 100;
            rest = rest - (honderdtallen * 100);

            int tientallen = rest / 10;
            rest = rest - (tientallen * 10);

            int eenheden = (rest / 1);

            Console.WriteLine("Het getal " + geheelGetalalstekst + " bestaat uit");
            Console.WriteLine(honderdtallen + " X 100");
            Console.WriteLine(tientallen + " X  10");
            Console.WriteLine(eenheden + " X   1");

        }
    }
}
