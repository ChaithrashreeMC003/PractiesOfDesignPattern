using Stratergypattern.Data;
using Stratergypattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergypattern.Statergies
{
    public class SearchByNameStrategy : ICustomerSearchStrategy
    {
        private readonly string _name;
        public SearchByNameStrategy(string name) => _name = name;

        public List<Customer> GetCustomers(AppDbContext context)
        {
            return context.Customers.Where(c => c.Name == _name).ToList();
        }
    }
}
