using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        // Load scriptures from the file
        List<Scripture> scriptures = LoadScriptures();

        if (scriptures.Count > 0)
        {
            // Select a random scripture from the loaded list
            Random random = new Random();
            int randomIndex = random.Next(0, scriptures.Count);
            Scripture selectedScripture = scriptures[randomIndex];

            // Initializing continueProgram as true to start the program execution.
            bool continueProgram = true;

            while (continueProgram)
            {
                // Display the selected scripture
                DisplayScripture(selectedScripture);

                if (selectedScripture.AllWordsHidden())
                {
                    // Check if all words are hidden, and exit the program
                    Console.WriteLine("All words hidden. Program will exit.");
                    continueProgram = false;
                }
                else
                {
                    // Checking if the user input is equal to "quit" to determine whether to exit the program.
                    Console.WriteLine("Press ENTER to remove a word or type 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        // Check if user wants to quit, and exit the program
                        continueProgram = false;
                    }
                    else
                    {
                        // Hide a random word and clear the console
                        selectedScripture.HideRandomWord();
                        selectedScripture.HideRandomWord();
                        Console.Clear();
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No scriptures found in the library.");
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        // Display the reference and visible scripture text
        Console.WriteLine("Reference: " + scripture.GetReference().GetText());
        Console.WriteLine("Scripture: " + scripture.GetScriptureText());
    }

    static List<Scripture> LoadScriptures()
    {
        // Load scriptures from the file
        List<Scripture> scriptures = new List<Scripture>();
        string filePath = "scriptures.txt";

        try
        {
            // Read each line from the file
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                // Split the line into reference and text parts
                string[] parts = line.Split('|');
                if (parts.Length >= 2)
                {
                    // Create a new reference object
                    string referenceText = parts[0];
                    Reference reference = new Reference(referenceText);

                    // Create a new scripture object and add it to the list
                    string text = parts[1];
                    Scripture scripture = new Scripture(reference, text);
                    scriptures.Add(scripture);
                }
            }
        }
        catch (System.IO.IOException ex)
        {
            // Handle file reading errors
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        return scriptures;
    }
}


// Showing Creativity and Exceeding Requirements:
// To show creativity and exceed require I made the program to load scriptures 
//from a file which I named Scriptures.txt
