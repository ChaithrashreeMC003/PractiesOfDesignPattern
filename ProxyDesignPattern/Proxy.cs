public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        if (_realSubject == null)
        {
            Console.WriteLine("Proxy: Creating RealSubject only when needed.");
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Proxy: Delegating request to RealSubject.");
        _realSubject.Request();
    }
}
