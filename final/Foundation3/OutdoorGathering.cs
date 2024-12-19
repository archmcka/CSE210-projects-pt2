public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weather)
        :base(title, description,dateTime, address)
        {
            _weather = weather;
        }
    public override string GetShortInfo()
    {
        return $"{GetDetails()}\nEvent Type: Outdoor Gathering";
    }
    public override string GetFullInfo()
    {
        return $"{GetDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weather}";
    }
}
