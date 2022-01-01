using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaett
{
    public class Group
    {
        private List<Student> room;
        public string name;
        public int no;
        public static int id;

        public Group(string name)
        {
            this.name = name;
            no = ++id;
            room = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            room.Add(student);
        }
    }
}
