using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int ID { get; set; }
        public static int id { get; set; }

        public Student(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
            ID = ++id;
        }

        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }
}
