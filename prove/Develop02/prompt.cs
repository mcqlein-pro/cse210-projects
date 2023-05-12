using System.Collections.Generic;

class PromptGenerator
{
    // Define a public property called Prompts, which is a List of strings.
    public List<string> _prompts;

    // Define a constructor for the class.
    public PromptGenerator()
    {
        // Initialize the Prompts list.
        _prompts = new List<string>();

        // Add a list of prompts to the Prompts list.
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is one thing that I learned today?");
        _prompts.Add("What is one thing that I'm grateful for today?");
        _prompts.Add("What is one way that I can improve myself?");
        _prompts.Add("What is one thing that I want to achieve tomorrow?");
        _prompts.Add("What is one thing that I want to achieve this week?");
        _prompts.Add("What is one skill that I would like to learn in the next month?");
        _prompts.Add("What is one thing that made me happy today?");
        _prompts.Add("What is one challenge that I faced today and how did I overcome it?");
        _prompts.Add("What is one thing that I am proud of myself for accomplishing this week?");
        _prompts.Add("What is one book or article that I would like to read in the next week? ");
        _prompts.Add("What is one thing that I can do to improve my mental health today? ");
        _prompts.Add("What is one thing that I can do to improve my relationships with others? ");
        _prompts.Add("What is one thing that I want to learn in the next month? ");
        
    }

    // Define a method that returns a random prompt from the Prompts list.
    public string GetRandomPrompt()
    {
        // Create a new System.Random object to generate a random number.
        int index = new System.Random().Next(_prompts.Count);

        // Return a random prompt from the Prompts list.
        return _prompts[index];
    }
}
