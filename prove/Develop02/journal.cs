using System; // Required for Console, DateTime
using System.Collections.Generic; // Required for List<>
using System.IO; // Required for StreamWriter, StreamReader

class Journal
{
    // Declare public properties to hold the journal entries, prompts, goals and userCredentials.
    public List<Entry> Entries;
    public PromptGenerator PromptGenerator;
    public List<Goal> goals;
    public List<UserCredentials> userCredentialsList;

    // Define a constructor method that initializes the entries, prompts, goals and userCredentialsList properties.
    public Journal()
    {
        Entries = new List<Entry>();
        PromptGenerator = new PromptGenerator();
        goals = new List<Goal>(); 
        userCredentialsList = new List<UserCredentials>();
    }

    // Define a method for writing a new journal entry.
    public void WriteNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt(); // Get a random prompt from the PromptGenerator
        Console.WriteLine(prompt); // Display the prompt to the user

        string response = Console.ReadLine(); // Get the user's response to the prompt
        Entry entry = new Entry(prompt, response, DateTime.Now.ToString("yyyy-MM-dd")); // Create a new Entry object
        Entries.Add(entry); // Add the new entry to the Entries list

        Console.WriteLine("Entry saved"); // Let the user know that the entry has been saved
    }

    // Define a method for displaying all journal entries to the console.
    public void DisplayJournal()
    {
        if (Entries.Count == 0) // Check if the Entries list is empty
        {
            Console.WriteLine("Nothing to display"); // Print "Nothing to display" if the list is empty
            return;
        }
        
        foreach (Entry entry in Entries) // Loop through all the entries in the Entries list
        {
            Console.WriteLine("{0} ({1}): {2}", entry._date, entry._prompt, entry._response); // Display each entry's date, prompt, and response
        }
    }


    // Define a method for saving the journal entries to a file.
    public void SaveJournalToFile()
    {
        // Prompt the user to enter a filename for the journal file.
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();

        // Open a new file stream for writing to the specified file.
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Write each journal entry to the file in the format "date|prompt|response".
            foreach (Entry entry in Entries)
            {
                writer.WriteLine("{0}|{1}|{2}", entry._date, entry._prompt, entry._response);
            }
        }

        // Write a confirmation message to the console.
        Console.WriteLine("Journal saved to file");
    }

    // Define a method for loading journal entries from a file.
    public void LoadJournalFromFile()
    {
        // Prompt the user to enter the filename of the journal file to load.
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();

        // If the specified file exists, clear the current journal entries and read the entries from the file.
        if (File.Exists(filename))
        {
            Entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                // Read each line of the file and split it into the date, prompt, and response fields.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');

                    // Create a new entry object from the fields and add it to the entries list.
                    Entry entry = new Entry(fields[1], fields[2], fields[0]);
                    Entries.Add(entry);
                }
            }

            // Write a confirmation message to the console.
            Console.WriteLine("Journal loaded from file");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    public void SetNewGoal()
    {
        // Prompt the user for goal information
        Console.WriteLine("Enter goal description:"); // Ask for description
        string description = Console.ReadLine(); // Read description input
        Console.WriteLine("Enter goal due date (yyyy-MM-dd):"); // Ask for due date
        string dueDate = Console.ReadLine(); // Read due date input
        Console.WriteLine("Enter goal progress:"); // Ask for progress
        int progress;
        if (!int.TryParse(Console.ReadLine(), out progress)) // Try to parse progress input as integer
        {
            Console.WriteLine("Invalid input. Progress must be a number."); // If input is invalid, display error message
            return; // Exit method
        }

        // Create a new goal object using the provided information
        Goal goal = new Goal(description, dueDate, progress);

        // Add the new goal object to the list of goals
        goals.Add(goal);
    }

    public void UpdateGoalProgress()
    {
        // Check if there are any goals set
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been set");
            return;
        }

        // Print a list of all the goals and their current progress
        Console.WriteLine("Goals:");

        foreach (var goal in goals)
        {
            Console.WriteLine("{0} - Progress: {1}", goal._description, goal._progress);
        }

        // Prompt the user to enter the description of the goal they want to update
        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        // Find the goal with the provided description in the list of goals
        Goal goalToUpdate = goals.Find(g => g._description == description);

        // Check if the goal was found
        if (goalToUpdate == null) 
        {
            Console.WriteLine("Goal not found");
            return;
        }

        // Print the current progress of the goal and prompt the user to enter the new progress
        Console.WriteLine("Current progress: {0}", goalToUpdate._progress);
        Console.WriteLine("Enter new progress:");

        int progress;
        if (!int.TryParse(Console.ReadLine(), out progress))
        {
            Console.WriteLine("Invalid input. Progress must be a number.");
            return;
        }

        // Update the progress of the goal and print a message to the console
        goalToUpdate._progress = progress;
        Console.WriteLine("Goal progress updated");
    }

    public void ViewGoalsAndProgress()
    {
        foreach (Goal goal in goals) // Loop through all the goal in the goals list
        {
            Console.WriteLine("Goal: {0}", goal._description ); 
            Console.WriteLine("Due-Date: {0}", goal._dueDate ); 
            Console.WriteLine("Progress: {0}", goal._progress );
        }
    }
    public void SaveGoalsToFile()
    {
        // Prompt the user to enter a filename to save the goals to
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();

        // Use a StreamWriter to write the goals to the specified file
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                // Write each goal to a line in the file in the format "Description|DueDate|Progress"
                writer.WriteLine("{0}|{1}|{2}", goal._description, goal._dueDate, goal._progress);
            }
        }

        // Print a message to the console to confirm that the goals were saved to the file
        Console.WriteLine("Goals saved to file");
    }

    public void LoadGoalsFromFile()
    {
        Console.WriteLine("Enter filename:"); // Prompt the user to enter a filename
        string filename = Console.ReadLine(); // Get the filename from the user

        if (File.Exists(filename)) // Check if the file exists
        {
            goals.Clear(); // Clear the Goal list

            using (StreamReader reader = new StreamReader(filename)) // Open a StreamReader to read from the file
            {
                string line;
                while ((line = reader.ReadLine()) != null) // Loop through all the lines in the file
                {
                    string[] fields = line.Split('|'); // Split the line into fields using the pipe character as the delimiter
                    Goal goal = new Goal(fields[0], fields[1], int.Parse(fields[2])); // Create a new Goal object using the fields
                    goals.Add(goal); // Add the new goal to the Goals list
                }
            }

            Console.WriteLine("Goal loaded from file"); // Let the user know that the goal has been loaded from the file
        }
        else
        {
            Console.WriteLine("File not found"); // Let the user know that the file was not found
        }
    }

    // Define a method for setting user credentials.
    // Define a method for setting user credentials.
    public void SetUserCredentials()
    {
        Console.WriteLine("Please set a new username and password.");

        Console.Write("Username: ");
        string newUsername = Console.ReadLine();

        Console.Write("Password: ");
        string newPassword = Console.ReadLine();

        userCredentialsList.Add(new UserCredentials { _username = newUsername, _password = newPassword });

        Console.WriteLine("User credentials set successfully.");
    }


    // Define a method for validating user credentials.
    public bool ValidateUserCredentials(string username, string password)
    {
        // Iterate over each UserCredentials object in userCredentialsList.
        foreach (UserCredentials credentials in userCredentialsList)
        {
            // Check if the provided username and password match the credentials.
            if (credentials._username == username && credentials._password == password)
            {
                // Return true if the credentials are valid.
                return true;
            }
        }

        // Return false if the credentials are not found.
        return false;
    }

    // Define a method for saving user credentials to a file.
    public void SaveUserCredentialsToFile()
    {
        // Create a new StreamWriter to write to the "credentials.txt" file.
        using (StreamWriter writer = new StreamWriter("credentials.txt"))
        {
            // Iterate over each UserCredentials object in userCredentialsList.
            foreach (UserCredentials credentials in userCredentialsList)
            {
                // Write the username and password to the file in the format "username|password".
                writer.WriteLine($"{credentials._username}|{credentials._password}");
            }
        }

        Console.WriteLine("User credentials saved to file.");
    }

    // Define a method for loading user credentials from a file.
    public void LoadUserCredentialsFromFile()
    {
        // Check if the "credentials.txt" file exists.
        if (File.Exists("credentials.txt"))
        {
            // Read all lines from the "credentials.txt" file.
            string[] lines = File.ReadAllLines("credentials.txt");

            // Iterate over each line in the file.
            foreach (string line in lines)
            {
                // Split the line by '|' to separate the username and password.
                string[] fields = line.Split('|');

                // Ensure the line has at least two elements.
                if (fields.Length >= 2)
                {
                    // Create a new UserCredentials object and add it to userCredentialsList.
                    userCredentialsList.Add(new UserCredentials { _username = fields[0], _password = fields[1] });
                }
                else
                {
                    // Handle the case where the line doesn't have enough elements.
                    Console.WriteLine("Invalid line format: " + line);
                }
            }

            Console.WriteLine("User credentials loaded from file.");
        }
        else
        {
            Console.WriteLine("No user credentials file found.");
        }
    }



}