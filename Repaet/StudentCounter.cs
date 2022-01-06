using System;

namespace Repaett
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Khayal", "Salimov");
            Student s2 = new Student("Khayal", "Salimov");
            Student s3 = new Student("Khayal", "Salimov");
            Student.Print();
        }

        class Student
        {
            public static int counter = 0;
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }


            public Student(string name,string surname)
            {
                Name = name;
                Surname = surname;
                ID = ++counter;
                Console.WriteLine(Name+" "+Surname+" "+ID);
            }

            public static void Print()
            {
                Console.WriteLine(counter);
            }
        }
    }
}
