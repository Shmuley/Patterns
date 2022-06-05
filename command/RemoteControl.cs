using System.Text;

public class RemoteControl
{
    Func<Action>[] onCommands;
    Func<Action>[] offCommands;
    Action undoCommand;

    public RemoteControl()
    {
        onCommands = new Func<Action>[7];
        offCommands = new Func<Action>[7];

        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = () => {return () => {};};
            offCommands[i] = () => {return () => {};};
        }
        undoCommand = () => {};
    }

    public void SetCommand(int slot, Func<Action> onCommand, Func<Action> offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        undoCommand = onCommands[slot]();
    }

    public void OffButtonWasPushed(int slot)
    {
        undoCommand = offCommands[slot]();
    }

    public void UndoButtonWasPushed()
    {
        undoCommand();
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