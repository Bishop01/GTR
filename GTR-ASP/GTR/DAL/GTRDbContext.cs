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
        }

    }
}
