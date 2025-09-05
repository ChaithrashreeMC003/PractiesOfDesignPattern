using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCompositEmployee
{
    public static class EmployeeFactory
    {
        public static IEmployee Create(string type, string name, decimal grossSalary)
        {
            return type.ToUpper() switch
            {
                "PERMANENT" => new PermanentEmployee(name, grossSalary, new IncomeTaxPolicy()),
                "INTERN" => new InternEmployee(name, grossSalary, new NoTaxPolicy()),
                _ => throw new ArgumentException("Invalid employee type")
            };
        }
    }
}
