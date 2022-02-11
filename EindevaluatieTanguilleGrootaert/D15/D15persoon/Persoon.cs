using System;

namespace D15.D15persoon
{
    class Persoon
    {
        public string Naam { get; set; }           

        public DateTime Geboortedatum { get; set; }
    
        public string Woonplaats { get; set; }

        public int Leeftijd()
        {
            int leeftijd = 0;
            DateTime dt = Geboortedatum.Date.AddYears(1);
            while (dt <= DateTime.Today)
            {
                leeftijd++;
                dt = dt.AddYears(1);
            }
            return leeftijd;
        }            
    }
}
