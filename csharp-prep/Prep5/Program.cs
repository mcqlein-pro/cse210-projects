using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // call the DisplayWelcome function

        string userName = PromptUserName(); // call the PromptUserName function and store the returned value in a variable
        int userNumber = PromptUserNumber(); // call the PromptUserNumber function and store the returned value in a variable
        int squaredNumber = SquareNumber(userNumber); // call the SquareNumber function with userNumber as a parameter, and store the returned value in a variable
        DisplayResult(userName, squaredNumber); // call the DisplayResult function with userName and squaredNumber as parameters
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Asks for and returns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Accepts an integer as a parameter and returns that number squared
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Accepts the user's name and the squared number and displays them
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! Your favorite number squared is {squaredNumber}.");
    }
}
