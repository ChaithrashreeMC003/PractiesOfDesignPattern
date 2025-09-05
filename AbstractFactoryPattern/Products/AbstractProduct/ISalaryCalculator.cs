using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products.AbstractProduct
{
    public interface ISalaryCalculator
    {
        decimal GetSalary(decimal baseSalary);
    }
}
