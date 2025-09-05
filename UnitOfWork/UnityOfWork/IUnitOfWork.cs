using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Models;
using UnitOfWork.Repository;

namespace UnitOfWork.UnityOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> Customers { get; }
        IRepository<Order> Orders { get; }
        Task<int> SaveAsync();
    }
}
