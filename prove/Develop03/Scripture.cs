using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _hiddenWordCount;

    public Scripture(Reference reference, string text)
    {
        // Constructor that initializes the scripture with the reference and text
        _reference = reference;
        _words = InitializeWords(text);
        _hiddenWordCount = 0;
    }

    private List<Word> InitializeWords(string text)
    {
        // Method to initialize the words in the scripture
        List<Word> wordList = new List<Word>();
        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            // Create a new Word object for each word in the text and add it to the list
            Word word = new Word(wordText);
            wordList.Add(word);
        }

        return wordList;
    }

    public Reference GetReference()
    {
        // Method to get the reference of the scripture
        return _reference;
    }

    public string GetScriptureText()
    {
        // Method to get the scripture text with visible and hidden words
        List<string> visibleWords = new List<string>();

        foreach (Word word in _words)
        {
            // Convert each Word object to its string representation (visible or hidden) and add it to the list
            visibleWords.Add(word.ToString());
        }

        // Combine the visible words into a single string separated by spaces
        return string.Join(" ", visibleWords);
    }

    public void HideRandomWord()
    {
        // Method to hide a random word in the scripture
        Random random = new Random();
        int randomIndex = random.Next(0, _words.Count);
        Word randomWord = _words[randomIndex];

        if (!randomWord.IsHidden())
        {
            // If the random word is not already hidden, hide it and increment the hidden word count
            randomWord.Hide();
            _hiddenWordCount++;
        }
        else if (_hiddenWordCount < _words.Count)
        {
            // If the hidden word count is less than the total word count and the random word is already hidden,
            // recursively call the method to select another random word and try again
            HideRandomWord();
        }

    }

    public bool AllWordsHidden()
    {
        // Method to check if all words in the scripture are hidden
        return _hiddenWordCount == _words.Count;
    }
}