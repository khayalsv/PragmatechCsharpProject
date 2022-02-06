using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Models
{
    public class PortoDbContext:DbContext
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options):base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
            new Slider
            {
                ID = 1,
                Image = "slide1.jpg",
                ClothType = "On Jackets",
                DisCount = "Get up to 60% off",
                Price = 130,
                TrendWord = "Winter Fashion Trends"
            },
            new Slider
            {
                ID = 2,
                Image = "slide2.jpg",
                ClothType = "On Coat",
                DisCount = "Get up to 10% off",
                Price = 200,
                TrendWord = "Season Fashion Trends"
            });
        }

    }
  
}
