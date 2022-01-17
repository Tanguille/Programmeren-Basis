namespace D15.D15bankrekening
{
    class Bankrekening
    {
        public decimal Saldo { get; private set; }
        public void Stort(decimal bedrag)
        {
            Saldo = Saldo + bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            Saldo -= bedrag;
        }
     
        public void SchrijfOver(Bankrekening doelRekening, decimal bedrag)
        {
            HaalAf(bedrag);
            doelRekening.Stort(bedrag);
        }

    }
}
