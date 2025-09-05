using ObeserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObeserverPattern.Observable
{
    public class Stock :IObservable
    {
        public string Name { get; set; }
        public int Price {  get; set; }

        List<IObserver> observers = new List<IObserver>();
        public void SetPrice(int _prince)
        {
            Price = _prince;
            Notify();
        }
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Remove(IObserver observer) { observers.Remove(observer); }
        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                Console.WriteLine($"Notification to {observer.Name}");
                observer.Update();
                //observer.Update(Name, Price); For PUSH Mthod
            }
        }

        public string GetName() { return Name; }
        public int GetPrice() { return Price; }
    }
}
