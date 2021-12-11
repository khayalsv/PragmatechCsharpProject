using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWinform
{
   
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int Id { get; set; }
        private static int id = 1;

        public Student(string name,string surname)
        {
            UpdateStudent(name, surname);
            this.name = name;
            this.surname = surname;
            Id = ++id;
        }

        public void UpdateStudent(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }


        public override string ToString()
        {
            return $"{name} {surname} ";
        }
    }
}
