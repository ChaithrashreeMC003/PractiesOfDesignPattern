using AbstractFactoryPattern.Products.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.ConcreteProduct
{
    public class PermanentSalaryCalculator : ISalaryCalculator
    {
        public decimal GetSalary(decimal baseSalary) => baseSalary + 5000;
    }
}
