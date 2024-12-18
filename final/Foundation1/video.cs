using System.ComponentModel.Design;

class Video 
{
    private string _title;
    private string _author;
    private int _length;

    private List <Comment> _comments;

    public Video(int length, string title,string author)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment); 
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List <Comment> GetComments()
    {
        return _comments;
    }
   public string GetTitle()
   {
    return _title;
   }
   public string GetAuthor()
   {
    return _author;
   }
   public int GetLength()
   {
    return _length;
   }
}  