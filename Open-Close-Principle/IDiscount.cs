using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
    }
}
