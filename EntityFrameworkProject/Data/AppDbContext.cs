using EntityFrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                IsDeleted = false,
                Title = "Blog-1",
                Desc = "Desc-1",
                Image = "blog-feature-img-1.jpg",
                Date = DateTime.Now
            },


            new Blog
            {
                Id = 2,
                IsDeleted = false,
                Title = "Blog-2",
                Desc = "Desc-2",
                Image = "blog-feature-img-3.jpg",
                Date = DateTime.Now
            },

            new Blog
            {
                Id = 3,
                IsDeleted = false,
                Title = "Blog-3",
                Desc = "Desc-3",
                Image = "blog-feature-img-4.jpg",
                Date = DateTime.Now
            }

            );

            modelBuilder.Entity<Setting>().HasData(
            new Setting
            {
                Id = 1,
                IsDeleted = false,
                Key = "Header Logo",
                Value = "logo.png"
               
            },
            new Setting
            {
                Id = 2,
                IsDeleted = false,
                Key = "Phone",
                Value = "64648393930039"

            },
            new Setting
            {
                Id = 3,
                IsDeleted = false,
                Key = "ProductTake",
                Value = "4"

            },
            new Setting
            {
                Id = 4,
                IsDeleted = false,
                Key = "CompanyBoss",
                Value = "Bakhtiyar Shamilzada"
            }
            );

        }
    }
}
