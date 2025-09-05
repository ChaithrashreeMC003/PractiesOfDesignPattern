using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionPrinciple
{
    public interface IBird
    {
        void run();
    }
    public class Ostrich : IBird
    {
        public void run()
        {
            Console.WriteLine("Ostrich is running");
        }
    }
}
