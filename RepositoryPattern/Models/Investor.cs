using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Investor
    {
        public int InvestorId { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public ICollection<Trade> Trades { get; set; }
    }
}
