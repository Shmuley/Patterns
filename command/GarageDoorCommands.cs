public class GarageDoorCommand : ICommand
{
    private readonly GarageDoor garageDoor;
    public Action ExecuteAction;

    public GarageDoorCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public Action Execute()
    {
        ExecuteAction();
        return () => {};
    }

    public void Undo(){
        this.garageDoor.Down();
    }
}

public class GarageDoor
{
    public GarageDoor() { }
    public void Up()
    {
        System.Console.WriteLine("Garage door is opening");
    }
    public void Down() { }
    public void Stop() { }
    public void LightOn() { }
    public void LightOff() { }
}
