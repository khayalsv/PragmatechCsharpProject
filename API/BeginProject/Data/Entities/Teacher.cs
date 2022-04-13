using System.Collections.Generic;

namespace BeginProject.Data.Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public ICollection<StudentTeacher> StudentTeachers { get; set; } //Many to Many Teachers<->Students
    }

}
