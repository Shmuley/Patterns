public interface Subject
{
    public void RegisterObserver(Observer observer);
    public void RemoveObserver(Observer observer);
    public void NotifyObservers();
}

public interface Observer
{
    public void Update(float temp, float humidity, float preassure);
}

public interface IDisplayElement
{
    public void Display();
    public void Unsubscribe();
}