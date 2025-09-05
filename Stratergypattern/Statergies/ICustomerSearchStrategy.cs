using Stratergypattern.Data;
using Stratergypattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Stratergypattern.Statergies
{
    public interface ICustomerSearchStrategy
    {
        List<Customer> GetCustomers(AppDbContext context);
    }
}
