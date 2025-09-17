public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {

    }

    public string getRandomPrompt()
    {
        int randomIndex = new Random().Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}