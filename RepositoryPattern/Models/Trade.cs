using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Trade
    {
        public int TradeId { get; set; }
        public int InvestorId { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string TradeType { get; set; } // "BUY" or "SELL"

        public Investor Investor { get; set; }
        public Stock Stock { get; set; }
    }
}
