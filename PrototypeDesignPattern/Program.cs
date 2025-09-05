using PrototypeDesignPattern;

class Program
{
    static void Main(string[] agrs)
    {
        Car car1 = new Car("Toyota", "Innova");
        car1.ShowDetails("Original");

        
        Car car2 = car1.Clone();
        car2.ShowDetails("Cloned");

       
        car1.Model = "Fortuner";

        Console.WriteLine("\nAfter modifying ORIGINAL:");
        car1.ShowDetails("Original");
        car2.ShowDetails("Cloned");
    }
}