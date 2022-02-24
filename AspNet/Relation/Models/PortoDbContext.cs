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

        public DbSet<Group> GROUP { get; set; }
        public DbSet<Student> STUDENT { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Group>()
          .HasOne(a => a.Students)
          .WithOne(b => b.Groups)
          .HasForeignKey<Student>(b => b.StudentID);
        }
    }
}
