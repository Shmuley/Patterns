// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        AverageConditionsDeisplay averageConditions = new AverageConditionsDeisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 57, 29.2f);
        currentDisplay.Unsubscribe();
        weatherData.SetMeasurements(78, 49, 28.7f);
    }
}