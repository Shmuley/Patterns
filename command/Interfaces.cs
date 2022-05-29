public interface ICommand
{
    public void Execute();
}

public class NoCommand : ICommand
{
    public void Execute()
    {
    }
}
