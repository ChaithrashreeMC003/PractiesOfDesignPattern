using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDesignPattern
{
    internal class WeekendDiscount : Idiscount
    {
      
        public int CalculateDiscount(int orderAmount)
        {
            return orderAmount - 10;
        }
    }
}
