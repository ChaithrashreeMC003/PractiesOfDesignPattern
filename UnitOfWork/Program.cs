using UnitOfWork.Data;
using UnitOfWork.Models;
using UnitOfWork.UnityOfWork;

public class Program
{
    static async Task Main(string[] args)
    {
        using var context = new ApDbContext();
        context.Database.EnsureCreated(); // Auto-create DB

        using var unitOfWork = new UnitOfWorker(context);

        Console.WriteLine("Customers:");
        var customers = await unitOfWork.Customers.GetAllAsync();
        foreach (var customer in customers)
        {
            Console.WriteLine($"- {customer.Name}");
        }

        Console.WriteLine("\nPlacing new order for Alice...");
        var newOrder = new Order { Product = "Tablet", Quantity = 3, CustomerId = 1 };
        await unitOfWork.Orders.AddAsync(newOrder);
        await unitOfWork.SaveAsync();

        Console.WriteLine("Orders for Alice:");
        var aliceOrders = context.Orders.Where(o => o.CustomerId == 1).ToList();
        foreach (var order in aliceOrders)
        {
            Console.WriteLine($"Product: {order.Product}, Qty: {order.Quantity}");
        }
        
    }
}