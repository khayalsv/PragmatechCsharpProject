using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaett
{
    public class Student
    {
        public string name;
        public string surname;
        public int no;
        public static int id;

        public Student(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
            no = ++id;
        }
    }
}
