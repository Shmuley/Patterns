public abstract class Beverage
{
    public DrinkSize Size = DrinkSize.Medium;
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

public enum DrinkSize {
    Large,
    Medium,
    Small
}