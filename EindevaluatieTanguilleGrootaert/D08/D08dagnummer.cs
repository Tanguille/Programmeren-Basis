using System;

namespace D08 {
    class D08dagnummer {
        static void Main(string[] args) {
            Console.Write("Geef een dagnummer: ");
            int dagnummer = int.Parse(Console.ReadLine());

            string[] dagen = new string[7]
            {"maandag","dinsdag","woensdag","donderdag","vrijdag","zaterdag","zondag"};

            Console.WriteLine($"Dagnummer {dagnummer} is {dagen[dagnummer-1]}.");
        }
    }
}
