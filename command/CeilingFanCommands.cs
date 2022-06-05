public class CeilingFanCommand : ICommand
{
    private readonly CeilingFan ceilingFan;
    private FanSpeed previousSpeed;
    public Action ExecuteAction;

    public CeilingFanCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }

    public Action Execute()
    {
        ExecuteAction();
        previousSpeed = ceilingFan.GetSpeed();
        return () => {};
    }

    public void Undo()
    {
        var currentSpeed = ceilingFan.GetSpeed();

        if (previousSpeed == FanSpeed.High)
        {
            ceilingFan.High();
        }
        else if (previousSpeed == FanSpeed.Medium)
        {
            ceilingFan.Medium();
        }
        else if (previousSpeed == FanSpeed.Low)
        {
            ceilingFan.Low();
        }
        else
        {
            ceilingFan.Off();
        }

        previousSpeed = currentSpeed;
    }
}

public class CeilingFan
{
    FanSpeed fanSpeed;

    public CeilingFan()
    {
        fanSpeed = FanSpeed.Off;
    }

    public void High()
    {
        fanSpeed = FanSpeed.High;
        System.Console.WriteLine($"Fan speed set to {fanSpeed.ToString()}");
    }
    public void Medium()
    {
        fanSpeed = FanSpeed.Medium;
        System.Console.WriteLine($"Fan speed set to {fanSpeed.ToString()}");
    }
    public void Low()
    {
        fanSpeed = FanSpeed.Low;
        System.Console.WriteLine($"Fan speed set to {fanSpeed.ToString()}");
    }
    public void Off()
    {
        fanSpeed = FanSpeed.Off;
        System.Console.WriteLine($"Fan speed set to {fanSpeed.ToString()}");
    }
    public FanSpeed GetSpeed()
    {
        return fanSpeed;
    }
}

public enum FanSpeed
{
    High,
    Medium,
    Low,
    Off
}