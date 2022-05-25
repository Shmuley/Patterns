public class Mocha : CondimentDecorator
{
    Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        this._beverage = beverage;
        this.Size = beverage.Size;
    }

    public override double Cost()
    {
        var cost = this._beverage.Cost();

        return cost = _beverage.Size switch
        {
           DrinkSize.Large => cost + .20,
           DrinkSize.Medium => cost + .15,
           DrinkSize.Small => cost + .10,
           _=> throw new NotImplementedException()
        };
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
        this.Size = beverage.Size;
    }

    public override double Cost()
    {
        var cost = this._beverage.Cost();

        return cost = _beverage.Size switch
        {
           DrinkSize.Large => cost + .20,
           DrinkSize.Medium => cost + .15,
           DrinkSize.Small => cost + .10,
           _=> throw new NotImplementedException()
        };
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Whip";
    }
}

public class Soy : CondimentDecorator
{
    Beverage _beverage;
    public Soy(Beverage beverage)
    {
        this._beverage = beverage;
        this.Size = beverage.Size;
    }
    public override double Cost()
    {
        var cost = this._beverage.Cost();

        return cost = _beverage.Size switch
        {
           DrinkSize.Large => cost + .50,
           DrinkSize.Medium => cost + .35,
           DrinkSize.Small => cost + .20,
           _=> throw new NotImplementedException()
        };
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Soy";
    }
}