using System;

namespace LetterGradeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your grade percentage: ");
            int grade = int.Parse(Console.ReadLine());

            string letter;
            char sign;

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            if (grade % 10 >= 7 && letter != "F" && letter != "A")
            {
                sign = '+';
            }
            else if (grade % 10 < 3 || letter == "F")
            {
                sign = '-';
            }
            else
            {
                sign = ' ';
            }

            Console.WriteLine($"Your letter grade is: {letter}{sign}");

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
            }
        }
    }
}
