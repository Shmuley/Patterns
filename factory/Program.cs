// See https://aka.ms/new-console-template for more information
var pizzaFactory = new NYPizzaStore();

var pizza = pizzaFactory.CreatePizza(PizzaType.Cheese);
pizza.Name = "NY Style Cheese Pizza";

pizza.Prepare();
pizza.Bake();
pizza.Cut();
pizza.Box();

pizza = pizzaFactory.CreatePizza(PizzaType.MeatLovers);
pizza.Name = "NY Style Meat Lovers Pizza";
pizza.Prepare();
pizza.Bake();
pizza.Cut();
pizza.Box();