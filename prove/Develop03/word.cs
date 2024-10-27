using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Word
{
    private bool _isHidden;
    private string _text;
     public bool IsHidden => _isHidden;

    public Word(string text)
    {
        _text= text;
        _isHidden=false;
    }
    
    public void Hide ()
    {
        _isHidden=true;
    }

    public string GetWord ()
    {
        return _isHidden? new string ('_',_text.Length) : _text;
    }
}