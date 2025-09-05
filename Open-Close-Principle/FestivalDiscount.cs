using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    public class FestivalDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.9m; 
        }
    }
}
