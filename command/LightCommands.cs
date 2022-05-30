public class LightOnCommand : ICommand
{
    Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.On();
    }
    public void Undo()
    {
        light.Off();
    }
}
public class LightOffCommand : ICommand
{
    Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.Off();
    }
    public void Undo()
    {
        this.light.On();
    }
}

public class Light
{
    public delegate void ChangeLight();

    public void On()
    {
        System.Console.WriteLine("Light has been turned on");
    }
    public void Off()
    {
        System.Console.WriteLine("Light has been turned off");
    }
}