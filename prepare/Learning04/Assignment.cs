using System;
public class Assignment
{
    protected string _studentName ;
    protected string _topic ;

    //Create a constructor for this class that receives a student name and topic and sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Add the method for GetSummary() to return the student's name and the topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}