public class Fan
{
    private FanState state;

    public Fan()
    {
        state = FanState.Off; // initial state
    }

    public void PressButton()
    {
        switch (state)
        {
            case FanState.Off:
                state = FanState.Low;
                Console.WriteLine("Fan is ON at LOW speed");
                break;

            case FanState.Low:
                state = FanState.Medium;
                Console.WriteLine("Fan speed changed to MEDIUM");
                break;

            case FanState.Medium:
                state = FanState.High;
                Console.WriteLine("Fan speed changed to HIGH");
                break;

            case FanState.High:
                state = FanState.Off;
                Console.WriteLine("Fan is turned OFF");
                break;
        }
    }
}
