using System;

namespace D15.D15stellingverhuur
{
    public class Periode
    {
        private DateTime _start;
        private DateTime _eind;
        private int _opbouwDuur;
        private int _afbraakDuur;

        public DateTime Start
        {
            get
            {
                return _start.AddHours(_opbouwDuur);
            }
        }

        public DateTime Eind
        {
            get
            {
                return _eind.AddHours(-_afbraakDuur);
            }
        }

        public Periode(DateTime start, DateTime eind, int opbouwDuur, int afbraakDuur)
        {
            _start = start;
            _eind = eind;
            _opbouwDuur = opbouwDuur;
            _afbraakDuur = afbraakDuur;
        }

        public int AantalUur()
        {
            TimeSpan ts = Eind - Start;
            double aantalUur = ts.TotalHours;
            double aantalUren = Math.Floor(aantalUur);
            //cast gevonden om double naar int om te zetten
            int aantalHeleUren = ((int)aantalUren);
            if (aantalUur - aantalHeleUren >= 0.5)
            {
                return aantalHeleUren + 1;
            }
            else
            {
                return aantalHeleUren;
            }
        }
    }


}
