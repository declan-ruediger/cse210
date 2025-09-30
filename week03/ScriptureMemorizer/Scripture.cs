public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        List<string> word_strings = text.Split(' ').ToList();

        foreach (string word_string in word_strings)
        {
            _words.Add(new Word(word_string));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = new Random().Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText = displayText + word.GetDisplayText() + " ";
        }

        // Remove last, unnecessary space.
        displayText = displayText.Substring(0, displayText.Length - 1);

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool anyWordNotHidden = false;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                anyWordNotHidden = true;
            }
        }

        return !anyWordNotHidden;
    }
}