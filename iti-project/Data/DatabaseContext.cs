using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace iti_project.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL("server=heltner.net;database=xbugtpgn_iti_project;user=xbugtpgn_admin;password=9_Ak@!Bh8QTd;SslMode=none");
        }
    }
}
