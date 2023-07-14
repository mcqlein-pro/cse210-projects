using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Gwaripe", "Abuja", "Nigeria");
        Address address2 = new Address("456 Elm St", "Addo Cresent", "Accra", "Ghana");
        Address address3 = new Address("789 Oak St", "Victoria Avenue", "Cape Town", "South Africa");
        Address address4 = new Address("155 Sapa St", "Lekki", "Lagos", "Nigeria");

        Event event1 = new Event("Talk Show", "Engaging conversations, interviews, and discussions in a talk show.", DateTime.Now, TimeSpan.FromHours(1), address4);
        Lecture lecture1 = new Lecture("Lecture On Health", "An informative lecture on various aspects of health and wellness.", DateTime.Now, TimeSpan.FromHours(2), address2, "Dr. Uyi Ehigie", 100);
        Reception reception1 = new Reception("Wedding Reception", "Celebratory union of love, music, food, and cherished memories shared.", DateTime.Now, TimeSpan.FromHours(3), address3, "michaelrsvp@example.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Sales Exhibition", "Sales Exhibition: Discover deals, products, and exclusive offers in one place.", DateTime.Now, TimeSpan.FromHours(4), address1, "Sunny");

        Console.WriteLine("Event 1 Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Lecture 1 Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception 1 Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering 1 Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering1.GetShortDescription());
    }
}
