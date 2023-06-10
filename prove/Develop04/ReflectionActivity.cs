using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    // List of prompts for reflection
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Constructor to initialize the name and description of the reflection activity
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    // Method to perform the reflection activity for the specified duration
    public override void PerformActivity(int duration)
    {
        Console.WriteLine("Performing activity...");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter when you have something in mind...");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;

        // Continue asking random questions until the specified duration is reached
        while (DateTime.Now < startTime.AddSeconds(duration))
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            Pause(5);
        }
    }

    // Method to get a random question from the list of questions
    private string GetRandomQuestion()
    {
        List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "How can you use what you learned in the future?"
        };

        Random random = new Random();
        return questions[random.Next(questions.Count)];
    }
}
