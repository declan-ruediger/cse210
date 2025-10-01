public class Video
{
    private string _title;
    private string _author;
    private int _duration; // in seconds
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public string GetDisplayText()
    {
        string displayText = string.Join('\n', [
            $"Title:    {_title}",
            $"Author:   {_author}",
            $"Duration: {_duration.ToString()}s",
            $"Number of Comments: {GetNumberOfComments().ToString()}"
            ]);

        displayText += "\nComments:";

        foreach (Comment comment in _comments)
        {
            displayText += "\n";
            displayText += comment.GetDisplayText();
        }

        return displayText;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
}