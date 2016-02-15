using System;
using System.Collections.Generic;

namespace InterviewApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Provide list of available persons in charge.
            Person p = new Person();
            p.PersonList = new List<Person>()
            {
                new Person("KUL","PEN","","Penny"),
                new Person("KUL","CHR","A22","Penny"),
                new Person("KUL","CHR","A23","Chen"),
                new Person("JHR","PEN","P18","Penny"),
                new Person("JHR","PEN","P18","Chen"),
                new Person("JHR","DOC","","Chen"),
                new Person("JHR","CAT","A22","Cath"),
                new Person("JHR","CAT","P19","Penny"),
                new Person("AMP","DOC","P17","Cath"),
                new Person("AMP","BOK","","Kent"),
                new Person("AMP","TBL","A23","Chen"),
                new Person("AMP","TBL","A22","Kent")
            };

            // Get value of parameters
            Console.Write("Please enter value for Area:");
            string area = Console.ReadLine();
            Console.Write("Please enter value for Type:");
            string type = Console.ReadLine();
            Console.Write("Please enter value for Code:");
            string code = Console.ReadLine();

            // Calls function to retrieve the person
            Console.WriteLine(p.RetrieveUser(area, type, code));
            Console.ReadLine();
        }
    }
}
