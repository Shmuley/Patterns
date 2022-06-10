// See https://aka.ms/new-console-template for more information
Duck duck = new MallardDuck();

Turkey wildTurkey = new WildTurkey();
TurkeyAdapter turkeyAdapter = new TurkeyAdapter(wildTurkey);
DuckAdapter duckAdapter = new DuckAdapter(duck);

duck.Fly();
duck.Quack();

wildTurkey.Fly();
wildTurkey.Gobble();

TestDuck(duck);
TestDuck(turkeyAdapter);

TestTurkey(wildTurkey);
TestTurkey(duckAdapter);

static void TestDuck(Duck duck)
{
    System.Console.WriteLine("Testing for ducks....");
    duck.Fly();
    duck.Quack();
}

static void TestTurkey(Turkey turkey)
{
    System.Console.WriteLine("Testing for turkeys....");
    turkey.Fly();
    turkey.Gobble();
}