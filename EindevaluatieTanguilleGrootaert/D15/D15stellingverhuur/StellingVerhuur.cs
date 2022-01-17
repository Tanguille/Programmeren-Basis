using System;

namespace D15.D15stellingverhuur
{
    internal class StellingVerhuring
    {
        public DateTime StartVerhuur { get; set; }
        public DateTime EindVerhuur { get; set; }

        private int _aantalUurOpbouw = 8;
        private int _aantalUurAfbraak = 4;

        public Levering Levering { get; set; }

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

        public StellingVerhuring(DateTime start, DateTime eind)
        {
            StartVerhuur = start;
            EindVerhuur = eind;
            AantalUurOpbouw = 8;
            AantalUurAfbraak = 4;
        }

        public StellingVerhuring(DateTime start, DateTime eind, int opbouwTijd)
        {
            StartVerhuur = start;
            EindVerhuur = eind;
            AantalUurOpbouw = opbouwTijd;
            AantalUurAfbraak = 4;
        }
        public StellingVerhuring(DateTime start, DateTime eind, int opbouwTijd, int afbraakTijd)
        {
            StartVerhuur = start;
            EindVerhuur = eind;
            AantalUurOpbouw = opbouwTijd;
            AantalUurAfbraak = afbraakTijd;
        }

        public Periode NettoVerhuurPeriode()
        {            
            return new Periode(StartVerhuur, EindVerhuur, AantalUurOpbouw, AantalUurAfbraak);
        }
        public decimal Prijs()
        {
            decimal result = 90 * AantalUurOpbouw;
            result += (5 * NettoVerhuurPeriode().AantalUur());
            result += 60 * AantalUurAfbraak;

            if (Levering != null)
            {
                result += 10 * Levering.AfstandInKm;
            }

            return result;
        }
    }
}
