public class CheesePizza : Pizza
{
    private IPizzaIngredientFactory _pizzaIngredientFactory;

    public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {
        Dough = _pizzaIngredientFactory.CreateDough();
        Cheeses = _pizzaIngredientFactory.CreateCheeses();
        Sauces = _pizzaIngredientFactory.CreateSauce();

        System.Console.WriteLine($"Preparing {Name}");
        System.Console.WriteLine($"Tossing {Dough} dough....");
        Sauces.ForEach(x => System.Console.WriteLine($"Adding {x.ToString()}"));
        Cheeses.ForEach(x => System.Console.WriteLine($"Adding {x.ToString()}"));

    }

    public override void Bake()
    {
        System.Console.WriteLine("Baking at 350F degrees for 25 minutes...");
    }

    public override void Box()
    {
        System.Console.WriteLine("Placing pizza in a regular pizza box...");
    }

    public override void Cut()
    {
        System.Console.WriteLine("Cutting the pizza into squares...");
    }
}

public class MeatPizza : Pizza
{
    private IPizzaIngredientFactory _pizzaIngredientFactory;
    public MeatPizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
    }
    public override void Prepare()
    {
        Dough = _pizzaIngredientFactory.CreateDough();
        Cheeses = _pizzaIngredientFactory.CreateCheeses();
        Sauces = _pizzaIngredientFactory.CreateSauce();
        Meats = _pizzaIngredientFactory.CreateMeats();

        System.Console.WriteLine($"Preparing {Name}");
        System.Console.WriteLine($"Tossing {Dough} dough....");
        Sauces.ForEach(x => System.Console.WriteLine($"Adding {x.ToString()}"));
        Cheeses.ForEach(x => System.Console.WriteLine($"Adding {x.ToString()}"));
        Meats.ForEach(x => System.Console.WriteLine($"Adding {x}"));
    }

    public override void Bake()
    {
        System.Console.WriteLine("Baking at 350F degrees for 25 minutes...");
    }

    public override void Box()
    {
        System.Console.WriteLine("Placing pizza in a regular pizza box...");
    }

    public override void Cut()
    {
        System.Console.WriteLine("Cutting the pizza into squares...");
    }
}