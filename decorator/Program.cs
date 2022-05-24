// See https://aka.ms/new-console-template for more information
Beverage coffee = new HouseBlend();
coffee = new Mocha(coffee);

System.Console.WriteLine($"Your {coffee.GetDescription()} costs {coffee.Cost()}");