public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
{
    private float temperature;
    private float humidity;
    IDisposable cancellation;

    public CurrentConditionsDisplay(IObservable<WeatherData> observable)
    {
        cancellation = observable.Subscribe(this);
    }
    public void Display()
    {
        System.Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }

    public void Unsubscribe()
    {
        cancellation.Dispose();
    }

    public void OnCompleted()
    {
        Display();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(WeatherData weatherData)
    {
        this.temperature = weatherData.GetTemperature();
        this.humidity = weatherData.GetHumidity();
    }
}

public class AverageConditionsDeisplay : IObserver<WeatherData>, IDisplayElement
{
    List<float> temperature;
    List<float> humidity;
    List<float> pressure;

    float avgTemperature;
    float avgHumidity;
    float avgPressure;

    public AverageConditionsDeisplay(IObservable<WeatherData> weatherData)
    {
        temperature = new List<float>();
        humidity = new List<float>();
        pressure = new List<float>();

        weatherData.Subscribe(this);
    }
    public void Display()
    {
        System.Console.WriteLine($"Average conditions: {avgTemperature}F degrees and {avgHumidity}% humidity");
    }

    public void OnCompleted()
    {
        avgTemperature = temperature.Sum() / temperature.Count();
        avgHumidity = humidity.Sum() / humidity.Count();
        avgPressure = pressure.Sum() / pressure.Count();
        Display();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(WeatherData weatherData)
    {
        temperature.Add(weatherData.GetTemperature());
        humidity.Add(weatherData.GetHumidity());
        pressure.Add(weatherData.GetPressure());
    }

    public void Unsubscribe()
    {
        throw new NotImplementedException();
    }
}
