using System;

namespace D15.D15stellingverhuur
{
    internal class StellingVerhuring
    {
        public DateTime StartVerhuur { get; set; }
        public DateTime EindVerhuur { get; set; }

        private int _aantalUurOpbouw = 8;
        private int _aantalUurAfbraak = 4;

        public int AantalUurOpbouw
        {
            get
            { return _aantalUurOpbouw; }
            set
            { _aantalUurOpbouw = value; }
        }

        public int AantalUurAfbraak
        {
            get
            { return _aantalUurAfbraak; }
            set
            { _aantalUurAfbraak = value; }
        }
      
        public StellingVerhuring(DateTime startVerhuur, DateTime eindVerhuur)
        {
            StartVerhuur = startVerhuur;
            EindVerhuur = eindVerhuur;
        }

        public Periode NettoVerhuurPeriode()
        {
            TimeSpan duurVerhuuur = EindVerhuur - StartVerhuur;
            return new Periode(duurVerhuuur.Hours);
        }
    }
}
