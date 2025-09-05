using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DefferentTypesOfEmployee
{
    public  class Employeefactoryclass
    {
        //Dictionary<string, IEmployee> employee = new Dictionary<string, IEmployee>();
        static UnityContainer container = new UnityContainer();
        public Employeefactoryclass() {
            //employee.Add("Intern", new Intern());
            //employee.Add("Permanent", new Permanent());
            container.RegisterType<IEmployee, Intern>("Intern");
            container.RegisterType<IEmployee, Permanent>("Permanent");

        }
        public  IEmployee GetInstence(string type)
        {
            //return employee[type].Clone();
            return container.Resolve<IEmployee>(type);
        }
    }
}
