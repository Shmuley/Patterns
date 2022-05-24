public class Mocha : CondimentDecorator
{
    Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        this._beverage = beverage;
    }

    public override double Cost()
    {
        return this._beverage.Cost() + .20;
    }

    public override string GetDescription()
    {
        return this._beverage.GetDescription() + ", Mocha";
    }
}

public class Whip : CondimentDecorator
{
    Beverage _beverage;

    public Whip(Beverage beverage)
    {
        this._beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + .20;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Whip";
    }
}

public class Soy : CondimentDecorator
{
    Beverage beverage;

    public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override double Cost()
    {
        return beverage.Cost() + .49;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }
}