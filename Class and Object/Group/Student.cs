using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Student
    {
        public string name;
        public string surname;
        public static int no=0;
     
        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            no++;
        }
    }

    class Group
    {
        public string groupName;
        public static int no=100;
        public int capacity = 3;

        public List<Student> student = new List<Student>();
        public Group(string groupName, int capacity)
        {
            this.groupName = groupName;
            this.capacity = capacity;
            no++;
        }

        public void AddStudent(string name,string surname)
        {
            if (student.Count<capacity)
            {
                student.Add(new Student(name,surname));
            }
            else
            {
                Console.WriteLine("yes/no ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "yes":
                        student.Add(new Student(name, surname));
                        break;
                    default:
                        break;
                }
            }
        }

    }
    class AddGroup
    {
        public string addname;
        public string addsurname;
        public static int no = 0;

        public AddGroup(string addname, string addsurname)
        {
            this.addname = addname;
            this.addsurname = addsurname;
            no++;
        }
    }

}