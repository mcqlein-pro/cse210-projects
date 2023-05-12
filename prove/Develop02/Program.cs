using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
         // Create a new instance of the Journal class
        Journal journal = new Journal();
        // Load user credentials from file
        journal.LoadUserCredentialsFromFile();

        // Check if user credentials list is empty
        if (journal.userCredentialsList.Count == 0)
        {
            // If no user credentials are found, set new user credentials and save them to file
            journal.SetUserCredentials();
            journal.SaveUserCredentialsToFile();
        }

        // Prompt the user to enter their username and password
        Console.WriteLine("Please enter your username and password to continue.");

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        // Validate user credentials
        // Validate user credential

        // Validate user credentials
        if (!journal.ValidateUserCredentials(username, password))
        {
            Console.WriteLine("Invalid username or password.");

            Console.Write("Would you like to create a new username and password? (yes/no): ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            {
                journal.SetUserCredentials();
                journal.SaveUserCredentialsToFile();

                // Update the username variable with the newly created username
                username = journal.userCredentialsList[journal.userCredentialsList.Count - 1]._username;
            }
            else
            {
                Console.WriteLine("Exiting program....");
                return;
            }
        }

        Console.WriteLine("Welcome To The Program, " + username + "!!!!");
        


        // Set the initial value of the 'exit' variable to false
        bool exit = false;
        
    // Start a loop that continues until the 'exit' variable becomes true
        while (!exit)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Set new goal");
            Console.WriteLine("6. Update goal progress");
            Console.WriteLine("7. Save goal to file");
            Console.WriteLine("8. Load goal from file");
            Console.WriteLine("9. View goals and progress");
            Console.WriteLine("10. Exit");

            Console.Write("Enter your choice (1-10): ");

             // Get the user's choice from the console.
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 10)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer between 1 and 10.");
                Console.Write("Enter your choice (1-10): ");
            }

            // Perform the appropriate action based on the user's choice.
            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveJournalToFile();
                    break;
                case 4:
                    journal.LoadJournalFromFile();
                    break;
                case 5:
                    journal.SetNewGoal();
                    break;
                case 6:
                    journal.UpdateGoalProgress();
                    break;
                case 7:
                    journal.SaveGoalsToFile();
                    break;
                case 8:
                    journal.LoadGoalsFromFile();
                    break;
                case 9:
                    journal.ViewGoalsAndProgress();
                    break;
                case 10:
                    Console.Write("Are you sure you want to exit? (yes/no) ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yes")
                    {
                        exit = true;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine();
        }
    }
}