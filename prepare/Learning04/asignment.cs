using Microsoft.VisualBasic;

public class Assignments
{
    private string _topic;
    private string _studentName;

    public Assignments(string topic, string studentName)
    {
        _topic = topic;
        _studentName = studentName;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetSummary()
    {
        string information = $"{_studentName}:/n{_topic}:";
        return information;
    }
}