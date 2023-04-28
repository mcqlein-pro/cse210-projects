using System;

// Define a class called Program
class Program
{
    // Define the main method
    static void Main(string[] args)
    {
        // Create a new instance of the Job class and set its fields
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create another new instance of the Job class and set its fields
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create a new instance of the Resume class and set its name field
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Add the two jobs to the list of jobs in the Resume instance
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Call the Display() method of the Resume instance to print the resume
        myResume.Display();
    }
}
