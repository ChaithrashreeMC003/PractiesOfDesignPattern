using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public List<Order> orders = new List<Order>();
    }
}
