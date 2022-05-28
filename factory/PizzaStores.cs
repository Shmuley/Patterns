public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaType pizzaType)
    {
        IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();
        Pizza pizza;

        return pizza = pizzaType switch
        {
            PizzaType.Cheese => new CheesePizza(pizzaIngredientFactory),
            PizzaType.MeatLovers => new MeatPizza(pizzaIngredientFactory),
            _=> throw new NotImplementedException()
        };
    }
}