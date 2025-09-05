using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        // Prototype method using MemberwiseClone
        public Car Clone()
        {
            return (Car)this.MemberwiseClone();
        }

        public void ShowDetails(string label)
        {
            Console.WriteLine($"{label} -> Car: {Brand} {Model}");
        }

    }
}
