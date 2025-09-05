
using Stratergypattern.ContextClient;
using Stratergypattern.Data;
using Stratergypattern.Model;
using Stratergypattern.Statergies;
using System;

class Program
{
    static void Main()
    {
        using var context = new AppDbContext();

       
        context.Customers.AddRange(
            new Customer { Name = "Alice", Age = 25 },
            new Customer { Name = "Bob", Age = 30 },
            new Customer { Name = "Charlie", Age = 25 }
        );
        //context.SaveChanges();

        var customerContext = new CustomerContext();

        
        customerContext.SetStrategy(new SearchAllStrategy());
        Print("All Customers:", customerContext.GetCustomers(context));

      
        customerContext.SetStrategy(new SearchByAgeStrategy(25));
        Print("Customers with Age 25:", customerContext.GetCustomers(context));

        
        customerContext.SetStrategy(new SearchByNameStrategy("Bob"));
        Print("Customer with Name 'Bob':", customerContext.GetCustomers(context));
    }

    static void Print(string title, List<Customer> customers)
    {
        Console.WriteLine($"\n{title}");
        foreach (var c in customers)
        {
            Console.WriteLine($"Id={c.Id}, Name={c.Name}, Age={c.Age}");
        }
    }
}