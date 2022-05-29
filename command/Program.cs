// See https://aka.ms/new-console-template for more information

RemoteControl control = new RemoteControl();

Light light = new Light();
GarageDoor garageDoor = new GarageDoor();

LightOnCommand lightOnCommand = new LightOnCommand(light);
LightOffCommand lightOffCommand = new LightOffCommand(light);

GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

control.SetCommand(1, lightOnCommand, lightOffCommand);
System.Console.WriteLine(control.ToString());
control.OnButtonWasPushed(1);
control.OffButtonWasPushed(1);