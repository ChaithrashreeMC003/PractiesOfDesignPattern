using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefferentTypesOfEmployee
{
    public class Permanent : IEmployee
    {
        public void Payment()
        {
            Console.WriteLine("I get monthly salary");
        }
        //public IEmployee Clone()
        //{
        //    return (IEmployee)this.MemberwiseClone();
        //}
    }
}
