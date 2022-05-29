using System.Text;

public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;

    public RemoteControl()
    {
        onCommands = new ICommand[7];
        offCommands = new ICommand[7];
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;

        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = new NoCommand();
            offCommands[i] = new NoCommand();
        }
    }

    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
    }

    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("---------------------------Remote Control---------------------------");
        for (int i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.AppendLine($"[slot {i}]: {onCommands[i].GetType().ToString()}     {offCommands[i].GetType().ToString()}");
        }

        return stringBuilder.ToString();
    }
}