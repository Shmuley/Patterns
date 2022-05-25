public class Espresso : Beverage 
{
    public Espresso(DrinkSize drinkSize) 
    {
        description = "Espresso";
        Size = drinkSize;
    }
    public override double Cost()
    {
        return 1.99;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend(DrinkSize drinkSize)
    {
        description = "House Blend Coffee";
        Size = drinkSize;
    }

    public override double Cost()
    {
        return .89;
    }
}