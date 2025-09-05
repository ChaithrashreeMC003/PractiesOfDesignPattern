using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Height = 150 },
            new Student { Id = 2, Name = "Bob", Height = 165 },
            new Student { Id = 3, Name = "Charlie", Height = 155 },
            new Student { Id = 4, Name = "David", Height = 170 }
        };

        var spec = new HeightLessThanSpecification(160);
            var filteredStudents = students.Where(s => spec.IsSatisfiedBy(s)).ToList();

        Console.WriteLine("Students shorter than 160 cm");
        foreach (var s in filteredStudents)
            {
                Console.WriteLine(s.Name + " - " + s.Height + " cm");
        }
        }
    }
}
