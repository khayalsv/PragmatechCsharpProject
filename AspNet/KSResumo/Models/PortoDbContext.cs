using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Models
{
    public class PortoDbContext : DbContext
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options) : base(options) { }

        public DbSet<Home> Homes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }


    }
}
