public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling the request (heavy work).");
    }
}
