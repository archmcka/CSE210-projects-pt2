public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    public Event (string title, string description,DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public virtual string GetDetails()
    {
        string info =$"title:{_title}\ndescription:{_description}\ndate time:{_dateTime}\naddress:{_address.GetAddress()}";
        return info;
    }
    public abstract string GetShortInfo();
    public abstract string GetFullInfo();

}