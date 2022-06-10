public class TurkeyAdapter : Duck
{
    private readonly Turkey turkey;

    public TurkeyAdapter(Turkey turkey)
    {
        this.turkey = turkey;
    }

    public void Quack()
    {
        turkey.Gobble();
    }

    public void Fly()
    {
        turkey.Fly();
    }
}

public class DuckAdapter : Turkey
{
    private readonly Duck duck;

    public DuckAdapter(Duck duck)
    {
        this.duck = duck;
    }

    public void Fly()
    {
        duck.Fly();
    }

    public void Gobble()
    {
        duck.Quack();
    }
}