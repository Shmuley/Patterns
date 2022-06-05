public class LightCommand : ICommand
{
    Light light;
    public Func<Action, Action> OnExecuteAction;
    public Func<Action, Action> OffExecuteAction;
    public Action PreviousState;

    public LightCommand(Light light)
    {
        this.light = light;
        PreviousState = () => { light.Off(); };
    }
}

public class Light
{
    Func<Action> State;

    public Light()
    {
       State = () => { return Off().Invoke(); };
    }

    public Func<Action> On()
    {
        var previousState = State; 
        System.Console.WriteLine("Light has been turned on");
        State = () => { return On().Invoke(); };
        return previousState;
    }
    public Func<Action> Off()
    {
        var previousState = State; 
        System.Console.WriteLine("Light has been turned off");
        State = () => {  return Off().Invoke(); };
        return previousState;
    }
    public Func<Action> GetState()
    {
        return State;
    }
}