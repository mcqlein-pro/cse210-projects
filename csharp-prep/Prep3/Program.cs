using System;

class Program
{
    static void Main(string[] args)
    {
        // Start a do-while loop that will keep looping as long as the user wants to play.
        bool playAgain;
        do
        {
            // Create a new Random object to generate a random number.
            Random randomGenerator = new Random();

            // Generate a random number between 1 and 100 (inclusive).
            int magicNumber = randomGenerator.Next(1, 100);

            int guess;
            int numGuesses = 0; // Initialize the number of guesses to 0.

            // Start a do-while loop that will keep looping as long as the user's guess is not correct.
            do
            {
                // Ask the user for their guess and convert their input to an integer.
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // If the guess is lower than the magic number, print "Higher".
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                // If the guess is higher than the magic number, print "Lower".
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                // If the guess is correct, print "You guessed it!" and the loop will exit.
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                // Increment the number of guesses.
                numGuesses++;

            // Check if the user's guess is not equal to the magic number and continue looping if it's not.
            } while (guess != magicNumber);

            // Print the number of guesses the user made.
            Console.WriteLine($"It took you {numGuesses} guesses.");

            // Ask the user if they want to play again.
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine();

            // Set the playAgain variable based on the user's response.
            playAgain = (playAgainResponse.ToLower() == "yes");

        // Continue looping as long as the user wants to play again.
        } while (playAgain);
    }
}
