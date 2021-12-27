using System;

namespace StudenCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Xeyal", "Selimov");
            Student student2 = new Student("Sadiq", "Ilyasli");
            Student student3 = new Student("Rasim", "Eliyev");
            Student.Print();
        }
    }

    class Student
    {
        private static int counter = 0;
        public int id { get; set; }
        public string name { get; set; }
        public string surnam { get; set; }
        public Student(string name, string surname)
        {
            this.name = name;
            this.surnam = surname;
            id = counter++;
            Console.WriteLine($"{name} {surname} {id}");
        }
        public static void Print()
        {
            Console.WriteLine(counter);
        }
    }

    
}
