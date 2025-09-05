using Adapterpattern.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Adapterpattern.Data
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<Trade> Trades { get; set; }

        private readonly string _connectionString;

    
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

       
        private AppDbContext()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())   // important for console apps
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // avoids double config when EF passes options
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

       
        private static readonly Lazy<AppDbContext> _instance =
            new Lazy<AppDbContext>(() => new AppDbContext());

        public static AppDbContext Instance => _instance.Value;
    }
}
