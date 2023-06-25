using System;
 class ChecklistGoal : Goal
{
    public int RequiredCount;
    public int CompletedCount;
     
    // Constructor for ChecklistGoal
    public ChecklistGoal(string name, string description, int points, int requiredCount) : base(name, description, points)
    {
        RequiredCount = requiredCount;
        CompletedCount = 0;
    }

    // Method to record an event for the checklist goal
    public override void RecordEvent()
    {
        CompletedCount++;
        if (CompletedCount >= RequiredCount)
        {
            _isCompleted = true;
        }
    }

    // Override of the ToString() method to provide a string representation of the checklist goal
    public override string ToString()
    {
        return base.ToString() + $" ({CompletedCount}/{RequiredCount} completed)";
    }
}
