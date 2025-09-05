class Program
{
    static void Main(string[] args)
    {
        Fan fan = new Fan();

        // Simulate button presses
        fan.PressButton(); // Off -> Low
        fan.PressButton(); // Low -> Medium
        fan.PressButton(); // Medium -> High
        fan.PressButton(); // High -> Off
        fan.PressButton(); // Off -> Low again

        Console.ReadLine();
    }
}
