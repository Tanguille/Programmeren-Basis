namespace Rekeningkantoor
{
    internal class Adres
    {
        public string Straat { get; private set; }
        
        //set niet meer private voor oefening rekeningkantoormieke
        public string Huisnummer { get; set; } 
        public string Postcode { get; private set; }
        public string Gemeente { get; private set; }

        public Adres(string straat, string huisnummer, string postcode, string gemeente)
        {
            Straat = straat;    
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
        }
    }
}
