using System;

// Abstract base class representing a mindfulness activity
public abstract class MindfulnessActivity
{
    // Protected fields to store activity name and description
    protected string _name;
    protected string _description;

    // Constructor to initialize the name and description of the activity
    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to start the activity
    public void Start()
    {
        Console.Clear();   // Clear the console
        DisplayStartingMessage();   // Display the starting message
        int duration = GetDuration();   // Get the duration of the activity
        PrepareToBegin();   // Prepare to begin the activity
        PerformActivity(duration);   // Perform the activity for the specified duration
        DisplayEndingMessage(duration);   // Display the ending message
        
    }

    // Method to display the starting message of the activity
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n=== {_name} ===");
        Console.WriteLine(_description);
        Pause(3);
    }

    // Method to get the duration of the activity from the user
    public int GetDuration()
    {
        while (true)
        {
            Console.Write("Enter the duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Invalid duration! Please enter a positive integer.");
        }
    }

    // Method to prepare to begin the activity
    public void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    // Abstract method to perform the activity
    public abstract void PerformActivity(int duration);

    // Method to display the ending message of the activity
    protected void DisplayEndingMessage(int duration)
    {
        Console.WriteLine($"Good job! You completed the {_name}.");
        Console.WriteLine($"Time: {duration} seconds");
        Pause(3);
    }

    // Method to pause the program for a specified number of seconds
    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
