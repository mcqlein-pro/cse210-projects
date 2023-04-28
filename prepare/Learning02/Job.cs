using System;

// Define a class called Job
public class Job
{
    // Define public fields for company, job title, start year, and end year
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Define a public method to display the job details
    public void Display()
    {
        // Print the job details in a formatted string
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}
