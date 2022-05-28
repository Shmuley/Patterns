using System.ComponentModel;

public abstract class PizzaStore
{
    public Pizza OrderPizza(PizzaType pizzaType)
    {
        Pizza pizza;

        pizza = CreatePizza(pizzaType);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    public abstract Pizza CreatePizza(PizzaType pizzaType);
}


public enum PizzaType
{
    Cheese,
    MeatLovers,
    Veggie,
    Pepperoni
}

public abstract class Pizza
{
    public string Name;
    public Dough Dough;
    public List<Sauce> Sauces;
    public List<Cheese> Cheeses;
    public List<Veggie> Veggies;
    public List<Meat> Meats;

    public abstract void Prepare();
    public abstract void Bake();
    public abstract void Cut();
    public abstract void Box();

    public void SetName(string name){
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }
}

public interface IPizzaIngredientFactory
{
    public Dough CreateDough();
    public List<Sauce> CreateSauce();
    public List<Cheese> CreateCheeses();
    public List<Veggie> CreateVeggies();
    public List<Meat> CreateMeats();

}

public enum Dough
{
    ThinCrust,
    ThickCrust,
    DeepDish
} 

public enum Sauce{
    Marinara,
    PlumTomatoSauce
}
public enum Cheese 
{
    [Description("Grated Reggiano Cheese")]
    GratedReggianoCheese,
    [Description("Shredded Mozzarella Cheese")]
    ShreddedMozzarellaCheese
}

public enum Veggie
{
    Peppers,
    Onions,
    BlackOlives
}

public enum Meat
{
    Pepperoni,
    Sausage,
    Bacon,
    Chicken
}