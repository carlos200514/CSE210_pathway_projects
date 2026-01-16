using System;
using System.IO;

public class Journal
{
    public List<Entry> _Entries= new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _Entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _Entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer= new StreamWriter(filename))
        {
            foreach (Entry entry in _Entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }
}