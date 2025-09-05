using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Models;

namespace UnitOfWork.Data
{
    public class ApDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public string _connectionString;
        public ApDbContext(){
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.Json").Build();
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasMany(c => c.orders).WithOne(o => o.Customer);
            modelBuilder.Entity<Order>().HasOne(o => o.Customer).WithMany(c => c.orders).HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<Customer>().HasData(
                 new Customer { CustomerId = 1, Name = "Alice" },
                new Customer { CustomerId = 2, Name = "Bob" }
                );
            modelBuilder.Entity<Order>().HasData(
                 new Order { OrderId = 1, Product = "Laptop", Quantity = 1, CustomerId = 1 },
                new Order { OrderId = 2, Product = "Phone", Quantity = 2, CustomerId = 2 }
                );
        }
    }
}
