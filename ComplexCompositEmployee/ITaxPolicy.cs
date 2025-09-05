using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCompositEmployee
{
    public interface ITaxPolicy
    {
        string Name { get; }
        decimal ComputeTax(decimal grossSalary);
    }
    public class IncomeTaxPolicy : ITaxPolicy
    {
        public string Name => "Income Tax 20%";

        public decimal ComputeTax(decimal grossSalary) => grossSalary * 0.20m;
    }

    public class NoTaxPolicy : ITaxPolicy
    {
        public string Name => "No Tax";

        public decimal ComputeTax(decimal grossSalary) => 0m;
    }
}
