public class Lecture : Event
{
    private string _speaker;
    private string _people;

    public Lecture(string title,string description,DateTime dateTime,Address address,string speaker,string people)
        : base(title,description,dateTime,address)
    {
        _speaker = speaker;
        _people = people;
    }
    public override string GetShortInfo()
    {
         return $"{GetDetails()}speaker {_speaker} people {_people}";
    }
    public override string GetFullInfo()
    {
        return $"{GetDetails()}speaker {_speaker} people {_people}";
    }
}