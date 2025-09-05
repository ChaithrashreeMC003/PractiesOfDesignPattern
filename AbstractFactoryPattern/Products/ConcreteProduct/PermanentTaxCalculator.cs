using AbstractFactoryPattern.Products.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.ConcreteProduct
{
    public class PermanentTaxCalculator : ITaxCalculator
    {
        public decimal GetTax(decimal salary) => salary * 0.2m;
    }
}
