using System;


namespace D16
{
    internal class Student
    {
        public string Naam { get; set; }
        public string Gemeente { get; set; }

        public Student(string naam, string gemeente)
        {
            Naam = naam;
            Gemeente = gemeente;    
        }        
    }
}
