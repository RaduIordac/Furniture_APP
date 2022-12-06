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
        private const string connectionString = @"Server=(localdb)\mssqllocaldb;
                                                    Database=FurnitureEfCoreDb;
                                                    Trusted_Connection=True";
        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString);
        }
    }
}
