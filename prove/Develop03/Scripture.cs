public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].HideWords();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Disappear())
            {
                return false;
            }
        }
        return true;
    }

    public void ScriptureDisplay()
    {
        Console.Write(_reference.ReferenceDisplay() + " ");
        foreach (Word word in _words)
        {
            Console.Write(word.DisplayWords() + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
