using System;

public class Scripture
{
    private Word[] _words;
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        _words = new Word[splitWords.Length];
        for (int i = 0; i < splitWords.Length; i++)
        {
            _words[i] = new Word(splitWords[i]);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine();

        for (int i = 0; i < _words.Length; i++)
        {
            Console.Write(_words[i].Display() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        int wordsToHide = 3;

        // Count visible words
        int visibleCount = 0;
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].IsHidden)
                visibleCount++;
        }

        if (visibleCount == 0)
            return;


        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(_words.Length);
            int attempts = 0;
            while (_words[index].IsHidden && attempts < _words.Length)
            {
                index = _random.Next(_words.Length);
                attempts++;
            }

            _words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].IsHidden)
                return false;
        }
        return true;
    }
}
