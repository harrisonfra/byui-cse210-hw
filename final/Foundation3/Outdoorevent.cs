public class Outdoorevent : Event
{
    private string _weather;

    public Outdoorevent(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public void WeatherCheck()
    {
        if (_weather.ToLower() == "sunny")
        {
            Console.WriteLine("The weather is great for an outdoor event!");
        }
        else
        {
            Console.WriteLine("The weather may not be ideal for an outdoor event.");
        }
    }

    public string GetFullDetails()
    {
        Console.WriteLine();
        return $"{GetStandardDetails()}\nType: Outdoor Event\nWeather: {_weather}";
    }

    public string GetShortDescription()
    {
        Console.WriteLine();
        return $"Outdoor Event: {GetEventTitle()} on {GetDate()}";
    }
}