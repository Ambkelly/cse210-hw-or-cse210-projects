using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for user input
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();

        // Convert string input to integer
        int gradePercentage = int.Parse(input);

        // Variables for letter grade and sign
        string letter = "";
        string sign = "";

        // Determine letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (if applicable)
        int lastDigit = gradePercentage % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && gradePercentage < 93)
        {
            sign = "-";  // A- for 90-92
        }

        // Display the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass or fail message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry. Keep trying and you'll do better next time!");
        }
    }
}
