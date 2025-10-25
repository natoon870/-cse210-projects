public class Word
{
    private string _text;
    private bool _disappear;

    public Word(string text)
    {
        _text = text;
        _disappear = false;
    }
    public void HideWords()
    {
        _disappear = true;

    }
    public bool Disappear()
    {
        return _disappear;
    }
    public string DisplayWords()
    {
        if (_disappear)
        {
            return "___";

        }
        else
        {
            return _text;
        }
    }
}
