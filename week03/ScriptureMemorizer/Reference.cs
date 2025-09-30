public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string book = _book;
        string chapter = _chapter.ToString();
        string verseText;
        if (_endVerse == 0)
        {
            // One verse only
            verseText = _verse.ToString();
        }
        else
        {
            //Start verse and end verse
            verseText = _verse.ToString() + "-" + _endVerse.ToString();
        }

        string displayText = book + " " + chapter + ":" + verseText;

        return displayText;
    }
}