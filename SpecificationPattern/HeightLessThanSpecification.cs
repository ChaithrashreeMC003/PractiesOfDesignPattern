using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    public class HeightLessThanSpecification : ISpecification<Student>
    {
        private readonly double maxHeight;

    public HeightLessThanSpecification(double maxHeight)
        {
            this.maxHeight = maxHeight;
    }

        public bool IsSatisfiedBy(Student student)
        {
            return student.Height < maxHeight;
        }
    }

}
