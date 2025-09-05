using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCompositEmployee
{
    public class InternEmployee : EmployeeBase
    {
        public InternEmployee(string name, decimal grossSalary, ITaxPolicy taxPolicy)
            : base(name, grossSalary, taxPolicy) { }
    }
}
