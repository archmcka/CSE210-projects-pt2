
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private bool _country;

    public Address(string street, string city, string state, bool country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool USA()
    {
       return _country;
    }
    
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

}