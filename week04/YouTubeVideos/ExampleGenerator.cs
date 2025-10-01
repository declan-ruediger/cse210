public class ExampleGenerator
{
    private List<string> _words = new List<String>();
    private int _numberLowerBound = 0;
    private int _numberUpperBound = 100;

    public ExampleGenerator(List<string> words, int numberLowerBound, int numberUpperBound)
    {
        _words = words;
        _numberLowerBound = numberLowerBound;
        _numberUpperBound = numberUpperBound;
    }

    public string GetRandomWords(int numberOfWords)
    {
        string randomWords = "";

        for (int i = 0; i < numberOfWords; i++)
        {
            randomWords += GetRandomWord();
            randomWords += " ";
        }

        randomWords = randomWords.Substring(0, randomWords.Length - 1);

        return randomWords;
    }

    private string GetRandomWord()
    {
        int randomIndex = new Random().Next(0, _words.Count);
        return _words[randomIndex];
    }

    public int GetRandomNumber()
    {
        return new Random().Next(_numberLowerBound, _numberUpperBound);
    }
}