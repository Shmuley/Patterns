internal class Program
{
    private static void Main(string[] args)
    {
        RemoteControl control = new RemoteControl();

        Light light = new Light();
        GarageDoor garageDoor = new GarageDoor();
        CeilingFan ceilingFan = new CeilingFan();
        LightCommand lightCommand = new LightCommand(light);

        Console.WriteLine(control.ToString());
        control.SetCommand(2, () => { return () => {light.On();};}, () => {return () => {light.Off();};});
        Console.WriteLine(control.ToString());
        control.OnButtonWasPushed(2);
        control.OffButtonWasPushed(2);
        control.OnButtonWasPushed(2);
        control.UndoButtonWasPushed();
        control.UndoButtonWasPushed();
        control.UndoButtonWasPushed();
        control.UndoButtonWasPushed();
        Console.WriteLine(control.ToString());
    }
}