public class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;

    }
    public string ReferenceDisplay()
    {
        if (_startverse == _endverse)
        {
            return $"{_book} {_chapter}:{_startverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startverse}-{_endverse}";
        }
    }
}
