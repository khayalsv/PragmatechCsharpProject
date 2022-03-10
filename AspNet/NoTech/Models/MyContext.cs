using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ServicesTitle> ServicesTitles { get; set; }
        public DbSet<ServicesBox> ServicesBoxes { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<ProjectBox> ProjectBoxes { get; set; }
        public DbSet<ProjectAbout> ProjectAbouts { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Helping> Helpings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Layout> Layouts { get; set; }









    }
}
