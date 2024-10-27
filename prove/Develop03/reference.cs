using System.Globalization;
class Reference{
    private int _startVerse;
    private int? _endVerse;
    private string _book;
    private int _chapter;

    public Reference(string book, int chapter,int verse)
    {
        _book=book; 
        _chapter=chapter;
        _startVerse=verse;

    }
    public Reference(string book, int chapter,int endVerse,int startVerse)
    {
         _book=book; 
        _chapter=chapter;
        _startVerse=startVerse;
        _endVerse=endVerse;

    }
    public string GetReferenceString ()
    {
        if (_endVerse.HasValue)
            return $"{(_book)} {_chapter}:{_startVerse}-{_endVerse}";
        else
            return $"{(_book)} {_chapter}:{_startVerse}";
    }



}