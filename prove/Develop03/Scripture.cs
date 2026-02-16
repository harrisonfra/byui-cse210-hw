using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());

        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }


    public void HideRandomWords()
    {
        for (int i = 0; i < 1; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
