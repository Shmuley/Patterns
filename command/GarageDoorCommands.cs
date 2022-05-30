public class GarageDoorOpenCommand : ICommand
{
    private readonly GarageDoor garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
        this.garageDoor.Up();
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
