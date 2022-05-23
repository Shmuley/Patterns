public class WeatherData : IObservable<WeatherData>
{
    private List<IObserver<WeatherData>> observers;
    private float temperature;
    private float humidity;
    private float pressure; 

    public WeatherData()
    {
        observers = new List<IObserver<WeatherData>>();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        foreach(var observer in this.observers){
            observer.OnNext(this);
            observer.OnCompleted();
        }
    }

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        observers.Add(observer);

        return new Unsubscriber<WeatherData>(observers, observer);
    }

    public float GetTemperature(){
        return this.temperature;
    }
    public float GetHumidity(){
        return this.humidity;
    }
    public float GetPressure(){
        return this.pressure;
    }
}

class Unsubscriber<WeatherData> : IDisposable
{
    private readonly List<IObserver<WeatherData>> displays;
    private readonly IObserver<WeatherData> display;

    public Unsubscriber(List<IObserver<WeatherData>> displays, IObserver<WeatherData> display)
    {
        this.displays = displays;
        this.display = display;
    }
    public void Dispose()
    {
        displays.Remove(display);
    }
}