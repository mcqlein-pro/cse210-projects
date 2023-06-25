using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker 
{
    // Private attributes
    private List<Goal> goals;
    private int totalPoints;

    // Constructor
    public GoalTracker()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    // Method to run the goal tracker
    public void Run()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Eternal Quest!");

        while (true)
        {
            // Display main menu options
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Save Goals to File");
            Console.WriteLine("4. Load Goals from File");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": // Call the method to create a new goal
                    CreateGoal();
                    break;
                case "2": // Call the method to view goals
                    ViewGoals();
                    break;
                case "3": // Call the method to save goals to a file
                    SaveGoalsToFile();
                    break;
                case "4": // Call the method to load goals from a file
                    LoadGoalsFromFile();
                    break;
                case "5": // Call the method to record an event
                    RecordEvent();
                    break;
                case "6": // Display exit message and return from the Run method
                    Console.WriteLine("Exiting Eternal Quest. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to create a new goal
    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("\n--- Create a New Goal ---");

        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Deadline Goal");
        Console.Write("Enter your choice: ");

        string input = Console.ReadLine();
        Goal goal;

        switch (input)
        {
            case "1": // Call the method to create a simple goal
                goal = CreateSimpleGoal();
                break;
            case "2": // Call the method to create an eternal goal
                goal = CreateEternalGoal();
                break;
            case "3": // Call the method to create a checklist goal
                goal = CreateChecklistGoal();
                break;
            case "4": // Call the method to create a deadline goal
                goal = CreateDeadlineGoal();
            break;
            default:
                Console.WriteLine("Invalid choice. Creating a Simple Goal by default.");
                // Create a simple goal by default
                goal = CreateSimpleGoal();
                break;
        }
        // Add the created goal to the list of goals
        goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    // Method to create a simple goal
    private Goal CreateSimpleGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        return new SimpleGoal(name, description, points);
    }

    // Method to create an eternal goal
    private Goal CreateEternalGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        return new EternalGoal(name, description, points);
    }

    // Method to create a checklist goal
    private Goal CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the required completion count for this goal: ");
        int requiredCount = Convert.ToInt32(Console.ReadLine());

        return new ChecklistGoal(name, description, points, requiredCount);
    }

    private Goal CreateDeadlineGoal()
{
    Console.Write("Enter the name of the goal: ");
    string name = Console.ReadLine();

    Console.Write("Enter the description of the goal: ");
    string description = Console.ReadLine();

    Console.Write("Enter the points for this goal: ");
    int points = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the deadline (YYYY-MM-DD): ");
    DateTime deadline = DateTime.Parse(Console.ReadLine());

    return new DeadlineGoal(name, description, points, deadline);
}

    // Method to view goals
    private void ViewGoals()
    {
        Console.Clear();
        Console.WriteLine("\n--- Your Goals ---");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            foreach (Goal goal in goals)
            {
                string completionStatus = goal.GetIsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{completionStatus} {goal}");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Total Points Earned: {totalPoints}");
    }

    // Method to save goals to a file
    private void SaveGoalsToFile()
    {
        Console.WriteLine("\n--- Save Goals to File ---");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found. Create goals first.");
            return;
        }

        Console.Write("Enter the file name to save: ");
        string fileName = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(totalPoints); // Save total points
                foreach (Goal goal in goals)
                {
                    string typeName = goal.GetType().Name;
                    string line;
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        line = $"{typeName},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetIsComplete()},{checklistGoal.RequiredCount},{checklistGoal.CompletedCount}";
                    }
                    else
                    {
                        line = $"{typeName},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetIsComplete()}";
                    }
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while saving goals: {ex.Message}");
        }
    }

    // Method to load goals from a file
    private void LoadGoalsFromFile()
    {
        Console.Clear();
        Console.WriteLine("\n--- Load Goals from File ---");

        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            goals.Clear();
            totalPoints = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    totalPoints = Convert.ToInt32(line); // Load total points
                }

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 5)
                    {
                        string typeName = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = Convert.ToInt32(parts[3]);
                        bool isCompleted = Convert.ToBoolean(parts[4]);

                        Goal goal;
                        switch (typeName)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(name, description, points);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(name, description, points);
                                break;
                            case nameof(ChecklistGoal):
                                int requiredCount = 1; // Default required count
                                int completedCount = 0; // Default completed count
                                if (parts.Length >= 7)
                                {
                                    requiredCount = Convert.ToInt32(parts[5]);
                                    completedCount = Convert.ToInt32(parts[6]);
                                }
                                goal = new ChecklistGoal(name, description, points, requiredCount)
                                {
                                    CompletedCount = completedCount
                                };
                                break;
                            default:
                                goal = new SimpleGoal(name, description, points);
                                break;
                        }

                        goal.SetCompletionStatus(isCompleted);
                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while loading goals: {ex.Message}");
        }
    }

    // Method to record an event
    private void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("\n--- Record Event ---");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found. Create goals first.");
            return;
        }

        Console.WriteLine("Select the goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
        Console.Write("Enter the number corresponding to the goal: ");

        string input = Console.ReadLine();
        int selectedIndex;
        if (int.TryParse(input, out selectedIndex) && selectedIndex >= 1 && selectedIndex <= goals.Count)
        {
            Goal selectedGoal = goals[selectedIndex - 1];

            selectedGoal.RecordEvent();
            totalPoints += selectedGoal.GetPoints();

            Console.WriteLine($"Congratulations! You earned {selectedGoal.GetPoints()} points.");
            Console.WriteLine($"Total Points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
