public class JournalEntry
{
    public string _text;
    public string _date;
    public string _prompt;

    public void SaveEntry(string text, string date)
    {
        _text = text;
        _date = date;
    }

    public string GetEntryText()
    {
        return _text;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetFullEntry()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_text}";
    }
}
