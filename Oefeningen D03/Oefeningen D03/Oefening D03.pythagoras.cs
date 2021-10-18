using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Geef de basis van een driehoek in cm: ");
            double basis = double.Parse(Console.ReadLine());

            Console.Write("Geef de hoogte van een driehoek in cm: ");
            double hoogte = double.Parse(Console.ReadLine());

            double basisMacht = Math.Pow(basis, 2);
            double hoogteMacht = Math.Pow(hoogte, 2);
            double schuineZijdeMacht = basisMacht + hoogteMacht;
            double schuineZijde = Math.Sqrt(schuineZijdeMacht);

            Console.WriteLine($"De schuine zijde van de driehoek bedraagt {schuineZijde} cm.");

     
        }
    }
}
