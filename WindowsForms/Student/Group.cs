using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWinform
{
    public class Group
    {
        private List<Student> students;
        public string Name { get; set; }
        public int Id { get; set; }
        private static int id = 1;
        public Group(string name)
        {
            Name = name;
            Id = id;
            id++;
            students = new List<Student>();
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public override string ToString()
        {
            return Name;
        }

        public List<Student> GetAllStudent() => students;
    }
}
