using System;
public class Reference
{
    private string _text;

    public Reference(string text)
    {
        // Constructor that initializes the reference text
        _text = text;
    }

    public string GetText()
    {
        // Method that returns the reference text
        return _text;
    }
}
