using ObeserverPattern.Observable;
using ObeserverPattern.Observer;

class Program
{
    static void Main()
    {
        Stock stock = new Stock()
        {
            Name = "TATA",
            Price = 300
        };
        MobileObserver mobileObserver = new MobileObserver(stock,"Mobile");
        LaptopObserver laptopObserver = new LaptopObserver(stock,"Laptop");

        stock.Add(mobileObserver);
        stock.Add(laptopObserver);
        
        stock.SetPrice(500);//only notify
       
        stock.Remove(mobileObserver);
        stock.SetPrice(400);//only laptop notify
        
        

    }
}