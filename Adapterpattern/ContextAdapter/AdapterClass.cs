using Adapterpattern.Data;
using Adapterpattern.Model;
using Adapterpattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapterpattern.ContextAdapter 
{
    internal class AdapterClass : ITradeRepository
    {
        private readonly AppDbContext _context;

        public AdapterClass(AppDbContext context)
        {
            _context = context;
        }

        public void Push(Trade trade)
        {

            try
            {
                _context.Trades.Add(new Trade { StockName = "TSLA", quantity = 10 });
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
            }
            
        }
    }
}
