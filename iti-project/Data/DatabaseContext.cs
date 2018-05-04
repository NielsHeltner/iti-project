using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace iti_project.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");

        }
    }
}
