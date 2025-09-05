using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data
{
    public class StockMarketContext : DbContext
    {
        public DbSet<Investor> Investors { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Trade> Trades { get; set; }

        public string _connectionstring { get; set; }
        public StockMarketContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionstring = configuration.GetConnectionString("DefaultConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Investors
            modelBuilder.Entity<Investor>().HasData(
                new Investor { InvestorId = 1, Name = "Alice", Balance = 10000 },
                new Investor { InvestorId = 2, Name = "Bob", Balance = 5000 }
            );

            // Seed Stocks
            modelBuilder.Entity<Stock>().HasData(
                new Stock { StockId = 1, Symbol = "AAPL", CurrentPrice = 150 },
                new Stock { StockId = 2, Symbol = "TSLA", CurrentPrice = 500 },
                new Stock { StockId = 3, Symbol = "MSFT", CurrentPrice = 300 }
            );
        }
    }
}
