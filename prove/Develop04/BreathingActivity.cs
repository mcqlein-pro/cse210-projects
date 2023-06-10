using System;

public class BreathingActivity : MindfulnessActivity
{
    // Constructor to initialize the name and description of the breathing activity
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Method to perform the breathing activity for the specified duration
    public override void PerformActivity(int duration)
    {
        Console.WriteLine("Performing activity...");

        DateTime startTime = DateTime.Now;

        // Continue the breathing activity until the specified duration is reached
        while (DateTime.Now < startTime.AddSeconds(duration))
        {
            Console.WriteLine("Breathe in...");
            Pause(3);

            Console.WriteLine("Breathe out...");
            Pause(3);
        }
    }
}
