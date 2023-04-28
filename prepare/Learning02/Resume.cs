using System;

// Define a class called Resume
public class Resume
{
    // Define public fields for the person's name and a list of jobs
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Define a public method to display the resume
    public void Display()
    {
        // Print the person's name
        Console.WriteLine($"Name: {_name}");
        // Print a header for the job section
        Console.WriteLine("Jobs:");

        // Loop through each job in the list
        foreach (Job job in _jobs)
        {
            // Call the Display() method of the Job class to print the job details
            job.Display();
        }
    }
}
