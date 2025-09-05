using Stratergypattern.Data;
using Stratergypattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergypattern.Statergies
{
    public class SearchByAgeStrategy : ICustomerSearchStrategy
    {
        private readonly int _age;
        public SearchByAgeStrategy(int age) => _age = age;

        public List<Customer> GetCustomers(AppDbContext context)
        {
            return context.Customers.Where(c => c.Age == _age).ToList();
        }
    }
}
