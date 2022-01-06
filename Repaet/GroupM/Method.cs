using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaett
{
    public class Method
    {
        public static List<Student> list = new List<Student>();
        public static List<Group> group = new List<Group>();



        public static void CreateStudent()
        {
            Console.WriteLine("Ad");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad");
            string surname = Console.ReadLine();
            list.Add(new Student(name, surname));
        }

        public static void CreateGroup()
        {
            Console.WriteLine("Ad");
            string groupName = Console.ReadLine();
            group.Add(new Group(groupName));
        }



        public static void ShowStudent()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
        }

        public static void ShowGroup()
        {
            foreach (var item in group)
            {
                Console.WriteLine($"{item.groupName}");
            }
        }

        public static void GroupAdd()
        {
            Console.WriteLine("Add Group No");
            string groupNumber = Console.ReadLine();
            Console.WriteLine("Add Student Name");
            string studentName = Console.ReadLine();

            foreach (var item in group)
            {
                if (item.groupName==groupNumber)
                {
                    foreach (var it in list)
                    {
                        if (it.Name==studentName)
                        {
                            Console.WriteLine("Student added");
                            break;
                        }
                    }
                }
            }
        }

        public static void ShowAdd()
        {
            Console.WriteLine("Enter the group name");
            string number = Console.ReadLine();
            foreach (var item in group)
            {
                if (item.groupName == number)
                {
                    foreach (var it in list)
                    {

                    }
                }
            }     
        }

        public static void ClassLenght()
        {
            Console.WriteLine("sinifin adini daxil edin");
            string className = Console.ReadLine();
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].groupName == className)
                {
                    Console.WriteLine(group[i].groupName);
                }
            }
        }

    }
}
