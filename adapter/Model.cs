public class WildTurkey : Turkey
{
    public void Fly()
    {
        System.Console.WriteLine("I'm flying a short distance");
    }

    public void Gobble()
    {
        System.Console.WriteLine("Gobble gobble!");
    }
}

public class MallardDuck : Duck
{
    public void Fly()
    {
        System.Console.WriteLine("I'm flying!");
    }

    public void Quack()
    {
        System.Console.WriteLine("Quack quack!");
    }
}