namespace Rekeningkantoor
{
    internal class Rekening
    {
        public string Nummer { get; private set; }
        public double Saldo { get; private set; }
        public Kantoor Kantoor { get; private set; }
        public Persoon Titularis { get; private set; }

        public Rekening(string nummer, double saldo, Kantoor kantoor, Persoon titularis)
        {
            Nummer = nummer;
            Saldo = saldo;
            Kantoor = kantoor;
            Titularis = titularis;
        }
    }
}
