public abstract class Goal
{
    // Private attributes
    private string _name;
    private string _description;
    private int _points;
    protected bool _isCompleted;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    // Getter for name
    public string GetName()
    {
        return _name;
    }

    // Getter for description
    public string GetDescription()
    {
        return _description;
    }

    // Getter for points
    public int GetPoints()
    {
        return _points;
    }

    // Getter for completion status
    public bool GetIsComplete()
    {
        return _isCompleted;
    }

    // Setter for completion status
    public void SetCompletionStatus(bool status)
    {
        _isCompleted = status;
    }

    // Abstract method for recording event (to be implemented by subclasses)
    public abstract void RecordEvent();

    // Override ToString() method
    public override string ToString()
    {
        return $"{_name} - {_description} ({_points} points)";
    }
}
