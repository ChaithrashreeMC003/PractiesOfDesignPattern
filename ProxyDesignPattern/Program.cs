class Program
{
    static void Main(string[] args)
    {
        ISubject proxy = new Proxy();

        Console.WriteLine("Client calls Request first time:");
        proxy.Request();

        Console.WriteLine("\nClient calls Request second time:");
        proxy.Request();

        Console.ReadLine();
    }
}