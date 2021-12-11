using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st1 = new Student("sss", "aaa", 32);
            Student st2 = new Student("sss", "aaa", 32);
            Student st3 = new Student("sss", "aaa", 32);
            Student st4 = new Student("sss", "aaa", 32);

            Console.WriteLine(st1.counter);
            Console.WriteLine(st2.counter);
            Console.WriteLine(st3.counter);
            Console.WriteLine(st4.counter);




        }
    }

    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int counter { get; set; }
        public static int no { get; set; }



        public Student(string name,string surname,int age) 
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            counter=no++;
        }
    }
}
