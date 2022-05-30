using System.Text;

public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;
    ICommand undoCommand;

    public RemoteControl()
    {
        onCommands = new ICommand[7];
        offCommands = new ICommand[7];

        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = new NoCommand();
            offCommands[i] = new NoCommand();
        }
        undoCommand = new NoCommand();
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
        undoCommand = onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
        undoCommand = offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        undoCommand.Undo();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("---------------------------Remote Control---------------------------");
        for (int i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.AppendLine($"[slot {i}]: {onCommands[i].GetType().ToString()}     {offCommands[i].GetType().ToString()}");
        }
        stringBuilder.AppendLine($"[Undo]: {undoCommand.GetType().ToString()}");

        return stringBuilder.ToString();
    }
}