namespace D15.D15artikelmetprijs
{
    internal class Artikel
    {
        public Artikel(decimal PrijsExclusiefBtw, decimal BtwPercentage)
        {
            this.PrijsExclusiefBtw = PrijsExclusiefBtw;
            this.BtwPercentage = BtwPercentage;
        }
        public Artikel(decimal PrijsExclusiefBtw)
        {
            this.PrijsExclusiefBtw = PrijsExclusiefBtw;
            this.BtwPercentage = 21m;
        }
        public decimal PrijsExclusiefBtw { get; set; }

        private decimal _btw;
        public decimal BtwPercentage { get; set; }
      
        public decimal PrijsInclusiefBtw()
        {
           return PrijsExclusiefBtw * (1 + BtwPercentage / 100);
        }
    }
}




