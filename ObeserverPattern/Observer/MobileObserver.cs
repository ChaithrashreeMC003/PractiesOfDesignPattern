using ObeserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObeserverPattern.Observer
{
    public class MobileObserver : IObserver
    {
        public Stock _stock;//only for pull method
        public string Name { get; set; }

        public MobileObserver(Stock stock, string name)
        {
            _stock = stock;
            Name = name;
        }
        public void Update()
        {
            
            Console.WriteLine($"The new stock value of {_stock.GetName()} : {_stock.GetPrice()}");
        }
    }
}
