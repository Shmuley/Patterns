public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public List<Cheese> CreateCheeses()
    {
        return new List<Cheese>(){
            Cheese.GratedReggianoCheese
        };
    }

    public Dough CreateDough()
    {
        return Dough.ThinCrust;
    }

    public List<Meat> CreateMeats()
    {
        return new List<Meat>(){
            Meat.Pepperoni,
            Meat.Sausage,
            Meat.Bacon
        };
    }

    public List<Sauce> CreateSauce()
    {
        return new List<Sauce>(){
            Sauce.Marinara
        };
    }

    public List<Veggie> CreateVeggies()
    {
        return new List<Veggie>(){
            Veggie.Peppers
        };
    }
}