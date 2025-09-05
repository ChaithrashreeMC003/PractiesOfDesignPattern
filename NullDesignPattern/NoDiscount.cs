using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDesignPattern
{
    public class NoDiscount : Idiscount
    {
        public int CalculateDiscount(int orderAmount)
        {
            return orderAmount;
        }
    }
}
