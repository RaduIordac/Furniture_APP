using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class FurnitureDbContext : DbContext
    {
        private const string connectionString = @"Server=PC-PC\SQLEXPRESS;
                                                    Database=FurnitureEfCoreDb;
                                                    Trusted_Connection=True;
                                                    Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString);
                }
        public DbSet<Product> Products { get; set; }
        public DbSet<Part> Parts     { get; set; }

    }
}
