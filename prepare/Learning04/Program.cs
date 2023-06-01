using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a simple assignment, call the method to get the summary, and then display it to the screen.
        Assignment assignment = new Assignment("John", "C#");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}