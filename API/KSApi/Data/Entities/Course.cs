using System;
using System.Collections.Generic;

namespace KSApi.Data.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? CreationTime { get; set; }

        //Many To Many
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
