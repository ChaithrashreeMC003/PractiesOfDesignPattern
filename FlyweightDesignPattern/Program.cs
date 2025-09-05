class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee(101, "Alice", "HR");
        Employee e2 = new Employee(102, "Bob", "IT");

        e1.ShowEmployee();
        e2.ShowEmployee();

        Console.ReadLine();
    }
}
