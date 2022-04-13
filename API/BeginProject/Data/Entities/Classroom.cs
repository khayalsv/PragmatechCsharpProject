using System.Collections.Generic;

namespace BeginProject.Data.Entities
{
    public class Classroom
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public ICollection<StudentClassroom> StudentClassrooms { get; set; } //Many to Many Classrooms<->Students

    }

}
