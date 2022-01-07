using System;


namespace D12
{
    internal class D12tonenmetonderdelen
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
           
            Console.WriteLine($"De datum van vandaag is {dateTime.Day}/{dateTime.Month}/{dateTime.Year} en het is nu {dateTime.Hour}:{dateTime.Minute}.");
        }
    }
}
