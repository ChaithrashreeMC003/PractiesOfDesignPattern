using ComplexCompositEmployee;

class Program
{
    static void Main(string[] args)
    {
        var emp1 = EmployeeFactory.Create("PERMANENT", "Alice", 50000m);
        var emp2 = EmployeeFactory.Create("INTERN", "Bob", 15000m);

        Console.WriteLine($"{emp1.Name} Net Salary: {emp1.CalculateNetSalary():N2}");
        Console.WriteLine($"{emp2.Name} Net Salary: {emp2.CalculateNetSalary():N2}");
    }
}