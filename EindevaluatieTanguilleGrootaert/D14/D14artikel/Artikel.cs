namespace D14.D14artikel
{
    internal class Artikel
    {
        private decimal _prijs;
        private decimal _btw = 0.21m;

        public void SetPrijsExclBTW(decimal prijs)
        { _prijs = prijs; }
        public decimal GetPrijsExclBTW()
        { return _prijs; }

        public void SetBTW(decimal btw)
        { _btw = btw/100; }
        public decimal GetBTW()
        { return _btw; }

        public decimal GetPrijsInclBTW()
        {return _prijs * (1 + _btw);}
    }
}


