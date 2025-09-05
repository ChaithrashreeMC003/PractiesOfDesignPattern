using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDesignPattern
{
    public  interface Idiscount
    {
        int CalculateDiscount(int orderAmount);
    }
}
