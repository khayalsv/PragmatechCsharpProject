using Microsoft.EntityFrameworkCore;
using Relation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class PortoDbContext: DbContext
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options) : base(options) { }

        public DbSet<Address> ADDRESS { get; set; }
        public DbSet<Student> STUDENT { get; set; }

        public DbSet<Author> AUTHOR { get; set; }
        public DbSet<Book> BOOK { get; set; }

        public DbSet<Customer> CUSTOMER { get; set; }
        public DbSet<Product> PRODUCT { get; set; }

        public DbSet<Hobby> HOBBY { get; set; }
        public DbSet<Teacher> TEACHER { get; set; }
        public DbSet<TeacherToHobby> TEACHERTOHOBBY { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>()
          .HasOne(a => a.Students)
          .WithOne(b => b.Addresses)
          .HasForeignKey<Address>(c => c.StudentID);


            modelBuilder.Entity<Customer>()
          .HasOne(a => a.Products)
          .WithOne(b => b.Customers)
          .HasForeignKey<Product>(c => c.CustomerID);

            modelBuilder.Entity<Book>()
           .HasOne(a => a.Authors)
           .WithMany(b => b.Books)
           .HasForeignKey(c => c.AuthorID);


            modelBuilder.Entity<TeacherToHobby>()
                .HasKey(x => new { x.TeacherID, x.HobbyID });
            modelBuilder.Entity<TeacherToHobby>()
                .HasOne(x => x.Hobby)
                .WithMany(x => x.TeacherToHobbies)
                .HasForeignKey(x => x.HobbyID);
            modelBuilder.Entity<TeacherToHobby>()
                .HasOne(x => x.Teacher)
                .WithMany(x => x.TeacherToHobbies)
                .HasForeignKey(x => x.TeacherID);
                
                

        }
    }
}
