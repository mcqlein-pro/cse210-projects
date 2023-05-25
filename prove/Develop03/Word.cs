using System;

public class Word
{
    private string _text;
    private bool isHidden;

    public Word(string text)
    {
        // Constructor that initializes the word with the given text and sets isHidden to false
        _text = text;
        isHidden = false;
    }

    public bool IsHidden()
    {
        // Method to check if the word is hidden
        return isHidden;
    }

    public void Hide()
    {
        // Method to hide the word by setting isHidden to true
        isHidden = true;
    }

    public new string ToString()
    {
        // Method to convert the word to its string representation
        if (isHidden)
        {
            // If the word is hidden, return a string of asterisks (*) with the same length as the original text
            return new string('*', _text.Length);
        }
        else
        {
            // If the word is not hidden, return the original text
            return _text;
        }
    }
}