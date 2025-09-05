

class Program
{
    static void Main(string[] args)
    {
        Light light = new Light();

        ICommand turnOn = new TurnOnLightCommand(light);
        ICommand turnOff = new TurnOffLightCommand(light);

        RemoteControl remote = new RemoteControl();

        remote.SetCommand(turnOn);
        remote.PressButton();   // Output: Light is ON

        remote.SetCommand(turnOff);
        remote.PressButton();   // Output: Light is OFF

        Console.ReadLine();
    }
}

