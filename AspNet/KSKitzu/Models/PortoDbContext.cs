using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class PortoDbContext: IdentityDbContext<User>
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options) : base(options) { }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<HomePageM> HomePageMs { get; set; }
        public DbSet<About> Aboutes { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}
