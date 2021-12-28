using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace REPEAT
{
    class Program
    {
        class Student
        {
            public string name { get; set; }
            public string group { get; set; }
            public int age { get; set; }
            public int no { get; set; }
            public static int id { get; set; }

            public Student(string name, string group,int age)
            {
                this.name = name;
                this.group = group;
                this.age = age;
                no = ++id;
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student("Sadiq", "a500",21);
            Student s2 = new Student("Xeyal", "a500",22);


            Console.WriteLine($"{s1.no} {s1.name}");
            Console.WriteLine(GetBirthYear(s1));

            ArrayList groups = new ArrayList();
            groups.Add(s1);
            groups.Add(s2);

            Console.WriteLine(groups.Count);
            
        }

        static int GetBirthYear(Student student)
        {
            return DateTime.Now.Year - student.age;
        }
    }
}
