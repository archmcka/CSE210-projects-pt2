public class Math : Assignments
{
    private string _textbookSection;
    private string _problems;

    public Math (string textbookSection, string problems, string topic, string studentName)
        :base (topic, studentName)
        {
            _textbookSection= textbookSection;
            _problems= problems;
        }
    public string GetHomeworkList()
    {
        return $"section {_textbookSection} problems {_problems}";
    }
}