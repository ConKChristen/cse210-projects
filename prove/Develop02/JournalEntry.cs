using System;

public class JournalEntry
{
    public string _promptText;
    public string _entryText;
    public string  _date;
    string[] _promptsText =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the highlight of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the best food I ate today?",
        "What was the hardest part about today?",
        "Who did you talk with today?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        Random rand = new Random();
        int index = rand.Next(_promptsText.Length);
        string _randomPrompt = _promptsText[index];

        _promptText = _randomPrompt;
        Console.WriteLine(_randomPrompt);
        _entryText = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_promptText} Response: {_entryText}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}