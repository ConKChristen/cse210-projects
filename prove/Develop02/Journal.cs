using System;
using System.IO; 

public class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void SaveJournal (string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry journalEntry in _journalEntries)
            {
                outputFile.WriteLine(journalEntry.CreateFileSystemString());
            }
        }
    }

    public void LoadJournal (string loadfile)
    {
        string[] lines = File.ReadAllLines(loadfile);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            JournalEntry entry = new JournalEntry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _journalEntries.Add(entry);
        }
    }
}