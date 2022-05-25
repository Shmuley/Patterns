// See https://aka.ms/new-console-template for more information
Beverage coffee = new HouseBlend(DrinkSize.Large);
coffee = new Mocha(coffee);
coffee = new Soy(coffee);

System.Console.WriteLine($"Your {coffee.Size.ToString()} {coffee.GetDescription()} costs {coffee.Cost()}");