namespace D14.D14bankrekening
{
    class Bankrekening
    {
        private decimal _saldo;
        public void Stort(decimal bedrag)
        {
            _saldo = _saldo + bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            _saldo = _saldo - bedrag;
        }
        public decimal Saldo()
        {
            return _saldo;
        }
        public void SchrijfOver(Bankrekening doelRekening, decimal bedrag)
        {
            this.HaalAf(bedrag);
            doelRekening.Stort(bedrag);
        }

    }
}
