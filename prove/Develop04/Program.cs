using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Create an instance of the BreathingActivity class
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Start();
            }
            else if (choice == "2")
            {
                // Create an instance of the ReflectionActivity class
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Start();
            }
            else if (choice == "3")
            {
                // Create an instance of the ListingActivity class
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Start();
            }
            else if (choice == "4")
            {
                // Create an instance of the GratitudeActivity class
                GratitudeActivity gratitudeActivity = new GratitudeActivity();
                gratitudeActivity.Start();
            }
            else if (choice == "4")
            {
                // Exit the program
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}

// To show creativity and exceed expectations, I added a new Gratitude activity to the program.
// The Gratitude activity will help users focus on expressing gratitude and appreciating the positive aspects of their lives. 

