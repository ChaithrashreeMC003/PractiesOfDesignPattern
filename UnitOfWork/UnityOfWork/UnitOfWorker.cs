using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Models;
using UnitOfWork.Repository;
using UnitOfWork.Data;

namespace UnitOfWork.UnityOfWork
{
    public class UnitOfWorker : IUnitOfWork
    {
        private readonly ApDbContext _context;
        public IRepository<Customer> Customers { get; }
        public IRepository<Order> Orders { get; }

        
        IRepository<Order> IUnitOfWork.Orders => throw new NotImplementedException();

        public UnitOfWorker(ApDbContext context)
        {
            _context = context;
            Customers = new Repository<Customer>(_context);
            Orders = new Repository<Order>(_context);
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}

