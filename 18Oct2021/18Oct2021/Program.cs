using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Oct2021
{
    class Student
    {
        string name;
        int age;
        int group;

        public Student(string name, int age, int group)
        {
            this.name = name;
            this.group = group;
            this.age = age;
        }


<<<<<<< HEAD
        public void addStd()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Group: ");
            int group = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name:{name}, Age:{age}, Group:{group}");

        }
=======
        //public void addStd()
        //{
        //    Console.WriteLine("Name: ");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Age: ");
        //    int age = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Group: ");
        //    int group = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"Name:{name}, Age:{age}, Group:{group}");

        //}
>>>>>>> 47491c515f724b379f54e95a7a4f7d96284a5c9c

        public int GetBirthYear()
        {
            DateTime date = DateTime.Today;

            return date.Year - this.age;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] std = new Student[2];
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Group: ");
                int group = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD
                

            }

            //Student std = new Student("",0,0);          
            //std.addStd();
            //Console.WriteLine(std.GetBirthYear());
=======
                Console.WriteLine($"Name:{name}, Age:{age}, Group:{group}");

            }
         

>>>>>>> 47491c515f724b379f54e95a7a4f7d96284a5c9c


        }
    }
}

#region

//Student std = new Student("",0,0);          
//std.addStd();
//Console.WriteLine(std.GetBirthYear());


//class Student
//{
//    string name;
//    int group;
//    int age;

//    public Student(string name, int group, int age)
//    {
//        this.name = name;
//        this.group = group;
//        this.age = age;


//    }

//    public int GetBirthYear()
//    {
//        DateTime date = DateTime.Today;

//        return date.Year - this.age;
//    }
//   

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //ArrayList studentList = new ArrayList();
//            //studentList.Add(student2);
//            //studentList.Add(21);
//            //studentList.Add(2000);
//            //foreach (var item in studentList)
//            //{
//            //    Console.WriteLine(item);
//            //}


//            Student student = new Student("Sadiq", 434, 19);
//            Student student2 = new Student("Xeyal", 208, 21);
//            Student student3 = new Student("Elsen", 208, 23);
//            Student student4 = new Student("Nurlan", 506, 25);
//            Student student5 = new Student("Rasim", 434, 24);

//            student.LIST();   
//            student2.LIST();
//            student3.LIST();
//            student4.LIST();
//            student5.LIST();


//            Console.WriteLine(student2.GetBirthYear());
//        }
//    }

//}
#endregion