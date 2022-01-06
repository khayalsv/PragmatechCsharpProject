using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaett
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public static int id;

        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            No = ++id;
        }
    }
}
