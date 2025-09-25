using System;

class Program
{
    static void Main()
    {
        // Ask the user for their age and convert the input to an integer
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask the user if they've ever had a DUI and convert the input to a boolean
        // Assumes user will enter "true" or "false"
        Console.WriteLine("Have you ever had a DUI?");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask the user how many speeding tickets they have and convert the input to an integer
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Apply the qualification rules:
        // - Must be over 15 years old
        // - Must not have any DUIs
        // - Must not have more than 3 speeding tickets
        bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

        // Print the result of the qualification check
    }
}