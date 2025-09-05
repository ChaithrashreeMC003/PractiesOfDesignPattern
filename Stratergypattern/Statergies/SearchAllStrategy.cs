using Stratergypattern.Data;
using Stratergypattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergypattern.Statergies
{
    public class SearchAllStrategy : ICustomerSearchStrategy
    {
        public List<Customer> GetCustomers(AppDbContext context)
        {
            return context.Customers.ToList();
        }

       
    }
}
