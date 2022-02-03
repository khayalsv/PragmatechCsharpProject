using System;
using System.Reflection;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Khayal";
            student.Surname = "Salimov";
            student.Age = 22;


            string x = "Name";
            Console.WriteLine(student.GetType().GetProperty(x).GetValue(student, null));


            MethodInfo method = student.GetType().GetMethod("GetStudent");
            Console.WriteLine(method.Invoke(student, new object[] { }).ToString());
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string GetStudent()
        {
            return Name + " " + Surname + " " + Age;
        }
    }
}
