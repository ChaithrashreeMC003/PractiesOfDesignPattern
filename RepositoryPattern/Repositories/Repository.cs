using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly StockMarketContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(StockMarketContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll() => _dbSet.ToList();

        public T Get(int id) => _dbSet.Find(id);

        public void Add(T entity) => _dbSet.Add(entity);

        public void Save() => _context.SaveChanges();
    }
}
