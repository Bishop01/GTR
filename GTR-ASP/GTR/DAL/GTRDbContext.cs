using Bogus;
using DAL.Entities;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class GTRDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SCHGJ5N;Initial Catalog=GTR;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[] {
                new User{Id=1, Name="Shanto", Email="abysswalkr01@gmail.com", Password=BCrypt.Net.BCrypt.HashPassword("1234") },
                new User{Id=2, Name="Alex", Email="alex@gmail.com", Password=BCrypt.Net.BCrypt.HashPassword("123456")},
            });

            List<Category> cats = new List<Category>();
            List<Brand> brands = new List<Brand>();

            for(int i=1; i<6; i++)
            {
                var catFaker = new Faker<Category>()
                .RuleFor(x => x.Name, x => x.Commerce.Categories(1)[0]);

                var brandFaker = new Faker<Brand>()
                    .RuleFor(x => x.Country, x => x.Company.Locale)
                    .RuleFor(x => x.Name, x => x.Company.CompanyName());

                var cat = catFaker.Generate();
                cat.Id = i;

                var brand = brandFaker.Generate();
                brand.Id = i;

                cats.Add(cat);
                brands.Add(brand);
            }

            modelBuilder.Entity<Category>().HasData(cats);
            modelBuilder.Entity<Brand>().HasData(brands);

            List<Product> products = new List<Product>();

            for(int i=1; i<30; i++)
            {
                var productFaker = new Faker<Product>()
                .RuleFor(x=>x.Id, i)
                .RuleFor(x=>x.Name, x=>x.Commerce.Product())
                .RuleFor(x=>x.Code, new Random().Next(1000, 9999))
                .RuleFor(x=>x.ProductBarcode, new Random().Next(111111,999999))
                .RuleFor(x=>x.ColorName, x=>x.Commerce.Color())
                .RuleFor(x=>x.Description, x=>x.Commerce.ProductDescription())
                .RuleFor(x=>x.ModelName, x=>x.Commerce.ProductAdjective())
                .RuleFor(x=>x.VariantName, x=>x.Commerce.ProductName())
                .RuleFor(x=>x.CategoryId, cats.ElementAt(new Random().Next(cats.Count)).Id)
                .RuleFor(x=>x.BrandId, brands.ElementAt(new Random().Next(brands.Count)).Id)
                .RuleFor(x=>x.UserId, new Random().Next(1,3));

                products.Add(productFaker.Generate());
            }

            modelBuilder.Entity<Product>().HasData(products);
        }

    }
}
