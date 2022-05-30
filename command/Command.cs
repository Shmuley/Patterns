public interface ICommand
{
    public void Execute();
    public void Undo();
}

public class NoCommand : ICommand
{
    public NoCommand()
    {
        
    }
    public void Execute()
    {
    }

    public void Undo()
    {
    }
}
