using AbstractFactoryPattern.Products.AbstractProduct;
using AbstractFactoryPattern.Products.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    internal class PermanentEmployeeFactory : IEmployeeFactory
    {
        public ISalaryCalculator CreateSalaryCalculator() => new PermanentSalaryCalculator();
        public ITaxCalculator CreateTaxCalculator() => new PermanentTaxCalculator();
    }
}
