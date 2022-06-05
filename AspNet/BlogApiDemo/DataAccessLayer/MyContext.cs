using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALIMOV\\SQLEXPRESS;Database=CoreBlogApiDemo;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
