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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>()
          .HasOne(a => a.Students)
          .WithOne(b => b.Addresses)
          .HasForeignKey<Address>(c => c.StudentID);

            modelBuilder.Entity<Book>()
           .HasOne(a => a.Authors)
           .WithMany(b => b.Books)
           .HasForeignKey(c => c.AuthorID);
        }
    }
}
