public class Reading : Assignments
{
    private string _title;
    public Reading (string title,string studentName,string topic)
    : base (studentName,topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}