public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startDate;
    public string _endDate;
    public void DisplayInformation()
    {
        Console.WriteLine($"{_jobTitle},{_company},{_startDate}-{_endDate}");
    }
} 