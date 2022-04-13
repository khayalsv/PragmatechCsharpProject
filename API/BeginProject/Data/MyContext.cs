using BeginProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginProject.Model
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        public DbSet<StudentClassroom> StudentClassrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentTeacher>().HasKey(x => new { x.StudentID, x.TeacherID });
            modelBuilder.Entity<StudentClassroom>().HasKey(x => new { x.StudentID, x.ClassroomID });
        }
    }
}
