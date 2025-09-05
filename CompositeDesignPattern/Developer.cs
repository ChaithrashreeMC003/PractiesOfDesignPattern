public class Developer : IEmployee
{
    private string _name;
    private string _position;

    public Developer(string name, string position)
    {
        _name = name;
        _position = position;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_position}: {_name}");
    }
}
