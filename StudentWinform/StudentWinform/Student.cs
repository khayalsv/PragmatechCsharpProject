using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWinform
{
    class Group
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private static int id = 0;
        public Group()
        {
            Id = ++id;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int id { get; set; }
    }
}
