using AbstractFactoryPattern.Products.AbstractProduct;
using AbstractFactoryPattern.Products.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public class InternEmployeeFactory : IEmployeeFactory
    {
        public ISalaryCalculator CreateSalaryCalculator() => new InternSalaryCalculator();
        public ITaxCalculator CreateTaxCalculator() => new InternTaxCalculator();
    }
}
