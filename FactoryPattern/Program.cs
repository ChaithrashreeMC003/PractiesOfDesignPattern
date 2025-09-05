
using FactoryPattern;

class Program
{
    static void Main(String[] args)
    {
        Factoryclass factory = new Factoryclass();
        IShape circle = factory.GetInstence("Circle");
        circle.Draw();
        IShape square = factory.GetInstence("Square");
        square.Draw();
    }
}
