using Adapterpattern.ContextAdapter;
using Adapterpattern.Data;
using Adapterpattern.Model;
using Adapterpattern.Repositories;
using System;

class Program
{
    static void Main()
    {
        using var context = AppDbContext.Instance;

        ITradeRepository repo = new AdapterClass(context);

        // Add trade using Push (business method)
        repo.Push(new Trade { Id = 1, StockName = "TSLA", quantity = 50 });

        Console.WriteLine(" Trade added using Adapter (Push = EF Core Add).");
   
    }
}
