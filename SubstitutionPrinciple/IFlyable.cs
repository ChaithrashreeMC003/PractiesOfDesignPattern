using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionPrinciple
{
    public interface IFlyable
    {
        void Fly();
    }
    public class Sparrow : IFlyable,IBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }

        public void run()
        {
            Console.WriteLine("Sparrow is running");
        }
    }
}
