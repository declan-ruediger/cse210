using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private static string _file_delimiter = "~`~`~";

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(String.Join(_file_delimiter, [
                    entry._date,
                    entry._promptText,
                    entry._entryText
                ]));
            }

        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] cells = line.Split(_file_delimiter);

            Entry entry = new Entry();
            entry._date = cells[0];
            entry._promptText = cells[1];
            entry._entryText = cells[2];

            _entries.Add(entry);
        }
    }
}