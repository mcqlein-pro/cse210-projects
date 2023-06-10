using System;

public class GratitudeActivity : MindfulnessActivity
{
    // Constructor to initialize the name and description of the gratitude activity
    public GratitudeActivity() : base("Gratitude Activity", "This activity will help you cultivate a sense of gratitude by reflecting on and expressing appreciation for the positive aspects of your life.")
    {
    }

    // Method to perform the gratitude activity for the specified duration
    public override void PerformActivity(int duration)
    {
        Console.WriteLine("Performing activity...");

        Console.WriteLine("Think about something or someone you are grateful for.");
        Pause(3);
        Console.WriteLine("Take a moment to reflect on why you are grateful for it.");
        Pause(3);
        
        DateTime startTime = DateTime.Now;

        // Continue asking random questions until the specified duration is reached
        while (DateTime.Now < startTime.AddSeconds(duration))
        {
            string grateful = GetRandomGrateful();
            Console.WriteLine(grateful);
            Pause(5);
        }

        
        }  
        private string GetRandomGrateful()
        {
            List<string> grateful = new List<string>()
            {
                "Express your gratitude in any form you prefer: write a letter, say it out loud, or simply think about it",
                "Take a moment to say out loud what you appreciate about a loved one and why you are grateful for them.",
                "Close your eyes and silently think about the things you are grateful for in your life, acknowledging their significance.",
                "Take a deep breath and express gratitude for the opportunities and experiences that have shaped who you are.",
                "Say thank you to someone who has helped you recently, acknowledging their support and kindness.",
                "Keep a gratitude journal and write down at least five things you are grateful for every day.",
                "Take a moment to appreciate the beauty of nature around you and express gratitude for the wonders of the natural world.",
            };

            Random random = new Random();
            return grateful[random.Next(grateful.Count)];
        }

             
        
}

