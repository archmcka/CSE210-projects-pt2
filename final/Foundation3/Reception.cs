public class Reception : Event
{
    private string _RSVP;
    public Reception(string title, string description, DateTime dateTime, Address address, string RSVP) 
        :base (title, description, dateTime,address)
        {
            _RSVP = RSVP;
        }
    public override string GetFullInfo()
    {
        return $"{GetDetails()}Event RSVP: {_RSVP}";
    }
    public override string GetShortInfo()
    {
        return $"{GetDetails()}Event RSVP: {_RSVP}";
    }
}