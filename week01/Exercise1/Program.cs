using System;

class Program
{
    static void Main()
    {
        // First name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Output
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
