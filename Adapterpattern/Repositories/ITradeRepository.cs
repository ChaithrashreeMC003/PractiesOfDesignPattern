using Adapterpattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapterpattern.Repositories
{
    public interface ITradeRepository
    {
        void Push(Trade trade);
    }
}
