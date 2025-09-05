public class Employee
{
    public int Id { get; }
    public string Name { get; }
    public string Department { get; }

    public Employee(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }

    public void ShowEmployee()
    {
        Console.WriteLine($"Employee Id: {Id}, Name: {Name}, Department: {Department}");
        Console.WriteLine($"Company: {CompanyInfo.CompanyName}, Address: {CompanyInfo.CompanyAddress}");
        Console.WriteLine("--------------------------");
    }
}
