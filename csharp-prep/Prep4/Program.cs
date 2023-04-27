using System;
using System.Collections.Generic; // Import the List class
using System.Linq; // Import the OrderBy() extension method

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>(); // Create a new List to store the numbers
        int number; // Declare the variable to store the user input
        int sum = 0; // Initialize the sum to zero
        int numEnter = 0; // Initialize the number of inputs to zero
        int max = int.MinValue; // Initialize the maximum number to the smallest possible integer value
        int smallestPositive = int.MaxValue; // Initialize the smallest positive number to the largest possible integer value

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine()); // Read the user input and parse it as an integer

            if (number != 0) // If the input is not zero, add it to the List and update the variables
            {
                numbers.Add(number); // Add the input to the List
                sum += number; // Add the input to the sum
                numEnter++; // Increment the number of inputs

                if (number > max) // Update the maximum number if the input is greater than the current maximum
                {
                    max = number;
                }

                if (number > 0 && number < smallestPositive) // Update the smallest positive number if the input is positive and smaller than the current smallest positive number
                {
                    smallestPositive = number;
                }
            }
        } while (number != 0); // Continue until the user inputs zero

        // Print the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(double)sum / numEnter:F2}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the List and print it
        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList(); // Sort the List using the OrderBy() extension method
        Console.WriteLine("The sorted list of numbers is: ");
        foreach (int n in sortedNumbers)
        {
            Console.Write(n + " ");
        }
    }
}
