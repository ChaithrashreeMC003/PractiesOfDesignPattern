using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDesignPattern
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        Idiscount _dis = null;
         public OrderItem(Idiscount dis)
        {
            _dis = dis?? new NoDiscount();
        }
        public void Discount()
        {
            int totalAmount = _dis.CalculateDiscount(Amount);
            Console.WriteLine("Amount after discount is: " + totalAmount);
        }
        
       
    }
}
