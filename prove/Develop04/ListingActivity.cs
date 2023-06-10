using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    // List of prompts to guide the user during the activity
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor to initialize the name and description of the listing activity
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // Method to perform the listing activity for the specified duration
    public override void PerformActivity(int duration)
    {
        Console.WriteLine("Performing activity...");

        // Randomly select a prompt from the list
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine(prompt);
        Pause(1);

        Console.WriteLine("Start listing...");

        // List to store the items listed by the user
        List<string> items = new List<string>();

        // Calculate the end time of the activity
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Continue listing items until the end time is reached
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"Number of items listed: {items.Count}");
    }
}
