using System;

namespace D15.D15stellingverhuur
{
    internal class Periode
    {
       public int DuurVerhuur { get; set; }
        StellingVerhuring start;
        StellingVerhuring eind;
        
        public DateTime Start
        {
            set
            {
                Start = start.StartVerhuur;
            }
        }

        public DateTime Eind
        {
            set
            {
                Eind = eind.EindVerhuur;
            }
        }
        


        public Periode(int duurVerhuur)
        {
            DuurVerhuur = duurVerhuur;
        }
    }
}
