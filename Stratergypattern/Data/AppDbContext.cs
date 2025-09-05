using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stratergypattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergypattern.Data
{
    public  class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public string _connectionstring { get; set; }
        public AppDbContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionstring = configuration.GetConnectionString("DefaultConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionstring);
        }

    }
}
