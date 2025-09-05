using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }

        public ICollection<Trade> Trades { get; set; }
    }
}
