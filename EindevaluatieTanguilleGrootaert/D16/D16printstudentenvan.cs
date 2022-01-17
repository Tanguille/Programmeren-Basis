using System;
using System.Collections.Generic;

namespace D16
{
    internal class D16printstudentenvan
    {
        static void Main(string[] args)
        {
            //zie Student.cs voor de klasse.
            List<Student> studenten = new List<Student>();

            studenten.Add(new Student("Jan", "Gent"));
            studenten.Add(new Student("Geert", "Gent"));
            studenten.Add(new Student("Jules", "Kortrijk"));
            studenten.Add(new Student("Jonas", "Kortrijk"));
            studenten.Add(new Student("Joris", "Brugge"));
            studenten.Add(new Student("Jacques", "Brugge"));
            studenten.Add(new Student("Erik", "Brugge"));

            foreach (Student student in studenten)
            {
                PrintStudent(student);
            }
            //Puur voor overzichtelijkheid
            Console.WriteLine();

            PrintStudentenVan(studenten, "Brugge");
        }
        static void PrintStudent(Student student)
        {
            Console.WriteLine(student.Naam + " uit " + student.Gemeente);
        }

        static void PrintStudentenVan(List<Student> studenten, string gemeente)
        {
            foreach (Student student in studenten)
            {
                if (student.Gemeente == gemeente)
                {
                    PrintStudent(student);
                }
            }
        }
    }
}
