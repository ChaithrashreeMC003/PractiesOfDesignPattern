using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapterpattern.Model
{
    public class Trade
    {
        public int Id { get; set; }
        public string StockName { get; set; }
        public int quantity { get; set; }
    }
}
