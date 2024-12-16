class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public bool USA()
    {
        return _address.USA();
    }
    public Address GetAddress()
    {
        return _address;
    }

}