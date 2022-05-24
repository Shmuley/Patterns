public class Espresso : Beverage 
{
    public Espresso() 
    {
        description = "Espresso";
    }
    public override double Cost()
    {
        return 1.99;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        description = "House Blend Coffee";
    }

    public override double Cost()
    {
        return .89;
    }
}