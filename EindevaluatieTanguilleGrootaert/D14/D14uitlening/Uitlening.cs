using System;

namespace D14.D14uitlening
{
    internal class Uitlening
    {
        public string _omschrijving;
        public DateTime _ontleendatum;

        public void SetOmschrijving(string omschrijving)
        { _omschrijving = omschrijving; }
        public string GetOmschrijving()
        { return _omschrijving; }

        public void SetOntleendatum(DateTime ontleendatum)
        { _ontleendatum = ontleendatum; }
        public DateTime GetOntleendatum()
        { return _ontleendatum; }

        public DateTime UitersteInleverdatum()
        { return _ontleendatum.AddDays(14); }
    }
}
