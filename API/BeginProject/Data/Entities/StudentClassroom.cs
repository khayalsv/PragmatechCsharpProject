namespace BeginProject.Data.Entities
{
    public class StudentClassroom
    {
        public int StudentID { get; set; }
        public int ClassroomID { get; set; }

        public Student Student { get; set; }
        public Classroom Classroom { get; set; }
    }

}
