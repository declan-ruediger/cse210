using System.IO;
using System.Runtime.CompilerServices;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private static string _file_delimiter = ",";

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
            string quoteCell(string rawCell)
            {
                return $"\"{rawCell.Replace("\"", "\"\"")}\"";
            }

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(String.Join(_file_delimiter, [
                    quoteCell(entry._date),
                    quoteCell(entry._promptText),
                    quoteCell(entry._entryText)
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

            string unquoteCell(string quotedCell)
            {
                // Remove Outer Quotes
                quotedCell = quotedCell.Substring(1, quotedCell.Length - 2);
                // Decode Quotes in Cell
                return quotedCell.Replace("\"\"", "\"");
            }

            Entry entry = new Entry();
            entry._date =       unquoteCell(cells[0]);
            entry._promptText = unquoteCell(cells[1]);
            entry._entryText =  unquoteCell(cells[2]);

            _entries.Add(entry);
        }
    }
}