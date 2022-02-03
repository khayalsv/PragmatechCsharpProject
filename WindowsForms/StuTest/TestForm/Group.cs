using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class Group
    {
        private List<Student> room;
        public string name { get; set; }
        public int ID { get; set; }
        public static int id { get; set; }
        public Group(string name)
        {
            ID = ++id;
            this.name = name;
            room = new List<Student>();
        }


        public void GroupAddStudent(Student student)
        {
            room.Add(student);
        }

        public void GroupDeleteStudent(Student student)
        {
            room.Remove(student);
        }

        public List<Student> GetAllStudent() => room;

        public override string ToString()
        {
            return name;
        }
    }
}
