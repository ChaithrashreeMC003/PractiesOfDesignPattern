using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefferentTypesOfEmployee
{
    public class Intern : IEmployee
    {
        public void Payment()
        {
            Console.WriteLine("I get a Stipend");
        }
        //public IEmployee Clone()
        //{
        //    return (IEmployee)this.MemberwiseClone();
        //}
    }
}
