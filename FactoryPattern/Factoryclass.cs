using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Factoryclass 
    {
        public IShape GetInstence(string shape)
        {
            if (shape.Equals("Circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            } else if ( shape.Equals("Square", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            } else
            {
                return null;
            }

        }
    }
}
