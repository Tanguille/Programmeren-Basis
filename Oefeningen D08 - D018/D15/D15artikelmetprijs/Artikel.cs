namespace D15.D15artikelmetprijs
{
    internal class Artikelmetprijs
    {
        public Artikelmetprijs()
        {
            _btw = 0.21m;
        }

        public decimal PrijsExclBTW { get; set; }

        private decimal _btw;
        public decimal Btw
        {
            get { return _btw; }
            set { _btw = value / 100; }           
        }

        public decimal PrijsInclBTW
        {
            get { return PrijsExclBTW * (1 + Btw); }
        }
    }
}




