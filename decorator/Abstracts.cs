public abstract class Beverage
{
    public string description = "Unknown beverage";

    public virtual string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
}

public abstract class CondimentDecorator : Beverage {
    public abstract override string GetDescription();

}