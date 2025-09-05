using NullDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        OrderItem OI = new OrderItem(new WeekendDiscount());
        OI.Amount = 100;
        OI.Discount();

        OrderItem OI2 = new OrderItem(null);
        OI2.Amount = 100;
        OI2.Discount();

    }
}