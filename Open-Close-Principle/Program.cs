using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal price = 1000;

            IDiscount festival = new FestivalDiscount();
            IDiscount regular = new RegularDiscount();

            Console.WriteLine($"Festival Discount Price: {festival.ApplyDiscount(price)}");
            Console.WriteLine($"Regular Discount Price: {regular.ApplyDiscount(price)}");
        }
    }
}
