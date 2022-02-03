using System;
using System.Collections.Generic;
using System.Reflection;

namespace TaskR
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Khayal";
            student.Surname = "Salimov";
            student.Age = 22;


            string x = "Surname";

            Console.WriteLine(student.GetType().GetProperty(x).GetValue(student,null));

        }

    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }



        public string GetStudent()
        {
            return Name + " " + Surname + " " + Age;
        }
        public string GetStudent2()
        {
            return Name + " " + Surname + " " + Age;
        }
        public string GetStudent3()
        {
            return Name + " " + Surname + " " + Age;
        }
        public string GetStudent4()
        {
            return Name + " " + Surname + " " + Age;
        }
        public string GetStudent5()
        {
            return Name + " " + Surname + " " + Age;
        }

    }
}
