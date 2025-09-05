using ObeserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObeserverPattern.Observer
{
    public class LaptopObserver : IObserver
    {
        public Stock _stock;//only for pull method
        public string Name { get; set; }
      
        public LaptopObserver(Stock stock,string name)
        {
            _stock = stock;
            Name = name;
        }
        public void Update()
        {
            var StockName = _stock.Name;//For pull
            var newPrice = _stock.Price;//For pull
            Console.WriteLine($"The new stock value of {StockName} : {newPrice}");
        }
    }
}
