using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            sparrow.Fly(); // Valid
            sparrow.run(); // Valid
            Ostrich ostrich = new Ostrich();
            // ostrich.Fly(); // Invalid - Ostrich cannot fly
            ostrich.run(); // Valid
        }
    }
}
