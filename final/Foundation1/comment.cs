class Comment
{
    private string _commenterText;
    private string _commentAuthor;
    public Comment(string commenterText, string commentAuthor)
    {
        _commenterText = commenterText;
        _commentAuthor = commentAuthor; 
    }
    public string GetAuthor()
    {
        return _commentAuthor;
    }
    public string GetText()
    {
        return _commenterText;
    }
}