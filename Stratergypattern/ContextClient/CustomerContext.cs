using Stratergypattern.Data;
using Stratergypattern.Model;
using Stratergypattern.Statergies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergypattern.ContextClient
{
    public class CustomerContext
    {
        private ICustomerSearchStrategy _strategy;

        public void SetStrategy(ICustomerSearchStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<Customer> GetCustomers(AppDbContext context)
        {
            if (_strategy == null)
                return new List<Customer>();

            return _strategy.GetCustomers(context);
        }
    }
}
