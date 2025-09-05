using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public class TradingService
    {
        private readonly IRepository<Investor> _investorRepo;
        private readonly IRepository<Stock> _stockRepo;
        private readonly IRepository<Trade> _tradeRepo;

        public TradingService(IRepository<Investor> investorRepo, IRepository<Stock> stockRepo, IRepository<Trade> tradeRepo)
        {
            _investorRepo = investorRepo;
            _stockRepo = stockRepo;
            _tradeRepo = tradeRepo;
        }

        public void BuyStock(int investorId, int stockId, int quantity)
        {
            var investor = _investorRepo.Get(investorId);
            var stock = _stockRepo.Get(stockId);

            var totalCost = stock.CurrentPrice * quantity;
            if (investor.Balance < totalCost)
            {
                Console.WriteLine($"{investor.Name} does not have enough balance to buy {quantity} {stock.Symbol} shares.");
                return;
            }

            investor.Balance -= totalCost;
            var trade = new Trade
            {
                InvestorId = investorId,
                StockId = stockId,
                Quantity = quantity,
                Price = stock.CurrentPrice,
                TradeType = "BUY"
            };

            _tradeRepo.Add(trade);
            _tradeRepo.Save();
            _investorRepo.Save();

            Console.WriteLine($"{investor.Name} bought {quantity} {stock.Symbol} shares at {stock.CurrentPrice} each.");
        }

        public void SellStock(int investorId, int stockId, int quantity)
        {
            var investor = _investorRepo.Get(investorId);
            var stock = _stockRepo.Get(stockId);

         
            var trade = new Trade
            {
                InvestorId = investorId,
                StockId = stockId,
                Quantity = quantity,
                Price = stock.CurrentPrice,
                TradeType = "SELL"
            };

            investor.Balance += stock.CurrentPrice * quantity;

            _tradeRepo.Add(trade);
            _tradeRepo.Save();
            _investorRepo.Save();

            Console.WriteLine($"{investor.Name} sold {quantity} {stock.Symbol} shares at {stock.CurrentPrice} each.");
        }
    }
}