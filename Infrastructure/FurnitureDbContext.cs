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
                .UseSqlServer(connectionString, b => b.MigrationsAssembly("FurnitureWebAPI"));
        }

        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Part> Parts     { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
