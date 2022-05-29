public sealed class Singleton
{
    private Singleton(){}
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

    public static Singleton GetInstance()
    {
        return lazy.Value;
    }

    public void AddThenMultiply(int a, int b){
        var value1 = a + b;
        var value2 = a * b;
    }
}