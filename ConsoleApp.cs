using System;

class Program
{
    static void Main(string[] args)
    {
        // Multiply input by 50
        Console.WriteLine("Enter a number to multiply by 50:");
        string input1 = Console.ReadLine(); // Read user input as string
        long number1 = Convert.ToInt64(input1); // Convert to long to support large numbers
        long result1 = number1 * 50; // Multiply by 50
        Console.WriteLine("Result: " + result1); // Print result

        // Add 25 to input
        Console.WriteLine("\nEnter a number to add 25:");
        string input2 = Console.ReadLine();
        double number2 = Convert.ToDouble(input2); // Convert to double for flexibility
        double result2 = number2 + 25;
        Console.WriteLine("Result: " + result2);

        // Divide input by 12.5
        Console.WriteLine("\nEnter a number to divide by 12.5:");
        string input3 = Console.ReadLine();
        double number3 = Convert.ToDouble(input3);
        double result3 = number3 / 12.5;
        Console.WriteLine("Result: " + result3);

        // Check if input is greater than 50
        Console.WriteLine("\nEnter a number to check if it's greater than 50:");
        string input4 = Console.ReadLine();
        double number4 = Convert.ToDouble(input4);
        bool isGreaterThan50 = number4 > 50; // Boolean comparison
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

        // Get remainder when input is divided by 7
        Console.WriteLine("\nEnter a number to get the remainder when divided by 7:");
        string input5 = Console.ReadLine();
        int number5 = Convert.ToInt32(input5); // Convert to int for modulus operation
        int remainder = number5 % 7; // Use modulus operator
        Console.WriteLine("Remainder: " + remainder);

        // Wait for user to press a key before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
