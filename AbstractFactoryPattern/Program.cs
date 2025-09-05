using AbstractFactoryPattern.Factory;

class Program
{
    static void Main(string[] args)
    {
        // Choose Factory dynamically
        IEmployeeFactory factory = new PermanentEmployeeFactory();
        CalculateNetSalary(factory, "Alice", 50000);

        factory = new InternEmployeeFactory();
        CalculateNetSalary(factory, "Bob", 15000);
    }

    static void CalculateNetSalary(IEmployeeFactory factory, string name, decimal baseSalary)
    {
        var salaryCalc = factory.CreateSalaryCalculator();
        var taxCalc = factory.CreateTaxCalculator();

        decimal salary = salaryCalc.GetSalary(baseSalary);
        decimal tax = taxCalc.GetTax(salary);
        decimal net = salary - tax;

        Console.WriteLine($"{name} = Gross: {salary}, Tax: {tax}, Net: {net}");
    }
}