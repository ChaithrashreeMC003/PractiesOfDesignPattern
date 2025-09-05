using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCompositEmployee
{
    public interface IEmployee
    {
        string Name { get; }
        decimal CalculateNetSalary();

    }
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; }
        protected decimal GrossSalary;
        protected readonly ITaxPolicy TaxPolicy;

        protected EmployeeBase(string name, decimal grossSalary, ITaxPolicy taxPolicy)
        {
            Name = name;
            GrossSalary = grossSalary;
            TaxPolicy = taxPolicy;
        }

        public virtual decimal CalculateNetSalary()
        {
            var tax = TaxPolicy.ComputeTax(GrossSalary);
            return GrossSalary - tax;
        }
    }
}
