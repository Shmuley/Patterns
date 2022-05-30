// See https://aka.ms/new-console-template for more information

RemoteControl control = new RemoteControl();

Light light = new Light();
GarageDoor garageDoor = new GarageDoor();
CeilingFan ceilingFan = new CeilingFan();

LightOnCommand lightOnCommand = new LightOnCommand(light);
LightOffCommand lightOffCommand = new LightOffCommand(light);
CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

System.Console.WriteLine(control.ToString());
control.SetCommand(0, lightOnCommand, lightOffCommand);
control.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);
control.SetCommand(2, ceilingFanLowCommand, ceilingFanOffCommand);
System.Console.WriteLine(control.ToString());
System.Console.WriteLine(control.ToString());
control.OnButtonWasPushed(0);
System.Console.WriteLine(control.ToString());
control.UndoButtonWasPushed();
control.OffButtonWasPushed(0);
control.OnButtonWasPushed(1);
control.OnButtonWasPushed(2);
control.UndoButtonWasPushed();
control.UndoButtonWasPushed();
control.UndoButtonWasPushed();
control.UndoButtonWasPushed();
System.Console.WriteLine(control.ToString());