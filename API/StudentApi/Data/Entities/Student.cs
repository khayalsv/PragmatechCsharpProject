using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginProject.Data.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public int GroupID { get; set; }
        public Group Group { get; set; }

        public ICollection<StudentTeacher> StudentTeachers { get; set; } //Many to Many Teachers<->Students
        public ICollection<StudentClassroom> StudentClassrooms { get; set; } //Many to Many Classrooms<->Students
    }

}
