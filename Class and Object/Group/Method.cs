using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Method
    {
        static List<Student> list = new List<Student>();
        static List<Group> group = new List<Group>();
        static List<AddGroup> addgroup = new List<AddGroup>();


        public static void CreateStudent()
        {
            Console.WriteLine("Telebe adi:");
            string name = Console.ReadLine();

            Console.WriteLine("Telebe soyadi:");
            string surname = Console.ReadLine();

           list.Add(new Student(name,surname));
        }

        public static void CreateGroup()
        {
            Console.WriteLine("Qrup adi :");
            string groupName = Console.ReadLine();

            Console.WriteLine("Tutumu:");
            int capacity = Int32.Parse(Console.ReadLine());

            group.Add(new Group(groupName,capacity));
        }

        public static void ShowStudent()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.name} {item.surname}");
            }
        }

        public static void ShowGroup()
        {
            foreach (var item in group)
            {
                Console.WriteLine($"{item.groupName} {item.capacity}");
            }
        }

        public static void AddGroupStudent()
        {
            Console.WriteLine("Qrup adin daxil edin: ");
            string groupNumber = Console.ReadLine();

            Console.WriteLine("Telebe adin daxil edin: ");
            string studentNumber = Console.ReadLine();

            addgroup.Add(new AddGroup(groupNumber,studentNumber));

            if (studentNumber!=null && groupNumber!=null)
            {
                foreach (var item in group)
                {
                    if (item.groupName==groupNumber)
                    {
                        foreach (var it in list)
                        {
                            if (it.name == studentNumber)
                            {
                                Console.WriteLine("bu adda telebe qeydiyyatdan kecmisdir");
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void ShowAddGroup()
        {
            foreach (var item in addgroup)
            {
                Console.WriteLine($"qrup: {item.addname} {item.addsurname}");
            }
        }
        public static void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
