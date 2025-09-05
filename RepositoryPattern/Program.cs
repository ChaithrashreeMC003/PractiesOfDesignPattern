using RepositoryPattern.Data;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using RepositoryPattern.Services;

internal class Program
{
    static void Main(string[] args)
    {
        using var context = new StockMarketContext();

        var investorRepo = new Repository<Investor>(context);
        var stockRepo = new Repository<Stock>(context);
        var tradeRepo = new Repository<Trade>(context);

        var tradingService = new TradingService(investorRepo, stockRepo, tradeRepo);

        Console.WriteLine("=== Welcome to Stock Market App ===\n");

        // List Investors
        Console.WriteLine("Available Investors:");
        foreach (var inv in investorRepo.GetAll())
        {
            Console.WriteLine($"{inv.InvestorId}. {inv.Name} (Balance: {inv.Balance})");
        }
        Console.Write("\nSelect Investor Id: ");
        int investorId = int.Parse(Console.ReadLine());

        // List Stocks
        Console.WriteLine("\nAvailable Stocks:");
        foreach (var stock in stockRepo.GetAll())
        {
            Console.WriteLine($"{stock.StockId}. {stock.Symbol} (Price: {stock.CurrentPrice})");
        }
        Console.Write("\nSelect Stock Id: ");
        int stockId = int.Parse(Console.ReadLine());

        // Choose action
        Console.Write("\nDo you want to BUY or SELL? (B/S): ");
        string action = Console.ReadLine().Trim().ToUpper();

        Console.Write("Enter Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        // Perform action
        if (action == "B")
        {
            tradingService.BuyStock(investorId, stockId, quantity);
        }
        else if (action == "S")
        {
            tradingService.SellStock(investorId, stockId, quantity);
        }
        else
        {
            Console.WriteLine("Invalid choice! Please select BUY (B) or SELL (S).");
        }

        // Show updated Investor Balance
        var investor = investorRepo.Get(investorId);
        Console.WriteLine($"\nUpdated Balance for {investor.Name}: {investor.Balance}");
    }
}