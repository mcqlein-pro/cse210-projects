using System;

public class DeadlineGoal : Goal
{
    private DateTime _deadline;

    public DeadlineGoal(string name, string description, int points, DateTime deadline)
        : base(name, description, points)
    {
        _deadline = deadline;
    }

    public DateTime GetDeadline()
    {
        return _deadline;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Did you complete the event for this goal? (Y/N)");
        string input = Console.ReadLine().ToUpper();

        if (input == "Y")
        {
            Console.Write("Enter the date you completed the event (YYYY-MM-DD): ");
            DateTime eventDate = DateTime.Parse(Console.ReadLine());

            if (eventDate <= _deadline)
            {
                _isCompleted = true;
                Console.WriteLine("Congratulations! You completed the event before the deadline.");
            }
            else
            {
                Console.WriteLine("Event completed, but it was after the deadline.");
            }
        }
        else
        {
            Console.WriteLine("Event not completed.");
        }
    }



    public override string ToString()
{
    return base.ToString() + $" (Deadline: {_deadline.ToShortDateString()})";
}

}
